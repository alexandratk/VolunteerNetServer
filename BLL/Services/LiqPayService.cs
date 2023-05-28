using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Data;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using LiqPay.SDK;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LiqPayService : ILiqPayService
    {
        public struct Pair
        {
            public int Weight;
            public int Price;
        }

        private const string StringSeparatorForDescription = ", ";
        public const int NumberOfDaysForAutoSelectAccordingEndDate = 7;

        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public LiqPayService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ValidationResult>> AddAsync(LiqPayModel value)
        {
            var validationResults = new List<ValidationResult>();
            if (value == null)
            {
                validationResults.Add(new ValidationResult("dataIsEmpty"));
                return validationResults;
            }
            var applicationIdsStr = value.Description.Split(StringSeparatorForDescription);
            for (int i = 0; i < applicationIdsStr.Length; i++)
            {
                var applicationId = Guid.Parse(applicationIdsStr[i]);
                var application = await unitOfWork.ApplicationRepository.GetByIdAsync(applicationId);

                if (application == null)
                {
                    validationResults.Add(new ValidationResult("applicationIdIsWrong"));
                    return validationResults;
                }

                var checkingDonate = CheckParams(value.Signature, value.Data);

                if (!checkingDonate)
                {
                    validationResults.Add(new ValidationResult("dataIsIncorrect"));
                    return validationResults;
                }

                var mapperDonate = mapper.Map<LiqPayModel, Donate>(value);
                mapperDonate.Id = Guid.Parse(value.OrderId);
                mapperDonate.DateTimeCreation = DateTime.Now;
                mapperDonate.ApplicationId = applicationId;

                decimal? currentAmount = application.RequiredSum - application.CurrentSum;

                if (currentAmount > (decimal) value.Amount)
                {
                    currentAmount = (decimal)value.Amount;
                }

                value.Amount -= (double)currentAmount;

                await unitOfWork.DonateRepository.AddAsync(mapperDonate);

                application.CurrentSum += currentAmount;

                await unitOfWork.ApplicationRepository.Update(application);
            }

            return validationResults;
        }

        public Task<LiqPayViewModel> CreateParams(LiqPayCreationModel liqPayCreationModel)
        {
            Guid orderId = Guid.NewGuid();
            LiqPayViewModel liqPayViewModel = new LiqPayViewModel();
            var liqPayClient = new LiqPayClient(LiqPayData.PublicKey, LiqPayData.PrivateKey);
            var data = liqPayClient.GenerateDataAndSignature(new LiqPay.SDK.Dto.LiqPayRequest()
            {
                Version = LiqPayData.Version,
                ActionPayment = LiqPay.SDK.Dto.Enums.LiqPayRequestActionPayment.Pay,
                Action = LiqPay.SDK.Dto.Enums.LiqPayRequestAction.Pay,
                Amount = liqPayCreationModel.Sum,
                Currency = LiqPayData.Currency,
                Description = liqPayCreationModel.ApplicationId.ToString(),
                OrderId = orderId.ToString()
            });

            liqPayViewModel.Data = data.Key;
            liqPayViewModel.Signature = data.Value;

            return Task.FromResult(liqPayViewModel);
        }

        public Task<LiqPayViewModel> CreateParamsAutoPayment(
            LiqPayAutoPaymentCreationModel liqPayAutoPaymentCreationModel)
        {
            Guid orderId = Guid.NewGuid();
            LiqPayViewModel liqPayViewModel = new LiqPayViewModel();
            var liqPayClient = new LiqPayClient(LiqPayData.PublicKey, LiqPayData.PrivateKey);

            List<string> applicationIdsStr = liqPayAutoPaymentCreationModel.ApplicationIds
                .Select(x => x.ToString()).ToList();
            string description = String.Join(StringSeparatorForDescription, applicationIdsStr);

            var data = liqPayClient.GenerateDataAndSignature(new LiqPay.SDK.Dto.LiqPayRequest()
            {
                Version = LiqPayData.Version,
                ActionPayment = LiqPay.SDK.Dto.Enums.LiqPayRequestActionPayment.Pay,
                Action = LiqPay.SDK.Dto.Enums.LiqPayRequestAction.Pay,
                Amount = liqPayAutoPaymentCreationModel.Sum,
                Currency = LiqPayData.Currency,
                Description = description,
                OrderId = orderId.ToString()
            });

            liqPayViewModel.Data = data.Key;
            liqPayViewModel.Signature = data.Value;

            return Task.FromResult(liqPayViewModel);
        }

        public bool CheckParams(string signature, string data)
        {
            LiqPayViewModel liqPayViewModel = new LiqPayViewModel();
            var liqPayClient = new LiqPayClient(LiqPayData.PublicKey, LiqPayData.PrivateKey);

            var mySignature = liqPayClient.CreateSignature(data);

            return mySignature == signature;
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LiqPayModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(LiqPayModel model)
        {
            throw new NotImplementedException();
        }

        public AutoSelectionViewModel AutoSelectWithSum(List<ApplicationViewModel> mapperApplications, int sum)
        {
            List<int> weight = new List<int>();
            foreach (var application in mapperApplications)
            {
                weight.Add((int)(application.RequiredSum - application.CurrentSum));
            }

            int n = mapperApplications.Count;
            int w = sum;
            List<AutoSelectionViewModel> result = new List<AutoSelectionViewModel>();
            Pair[,] arr = new Pair[n + 1, w + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= w; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        arr[i, j].Weight = 0;
                        arr[i, j].Price = 0;

                    }
                    else
                    {
                        if (weight[i - 1] > j)
                        {
                            arr[i, j] = arr[i - 1, j];
                        }
                        else
                        {
                            int p1 = arr[i - 1, j].Price;
                            int p2 = arr[i - 1, j - weight[i - 1]].Price + 1;
                            int w1 = arr[i - 1, j].Weight;
                            int w2 = arr[i - 1, j - weight[i - 1]].Weight + weight[i - 1];

                            if (w1 > w2 || (w1 == w2 && p1 > p2))
                            {
                                arr[i, j].Price = p1;
                                arr[i, j].Weight = arr[i - 1, j].Weight;
                            }
                            else
                            {
                                arr[i, j].Price = p2;
                                arr[i, j].Weight = arr[i - 1, j - weight[i - 1]].Weight + weight[i - 1];
                            }
                        }
                    }
                }
            }

            AutoSelectionViewModel autoSelect = new AutoSelectionViewModel();

            autoSelect.Sum = 0;
            int indexI = n, indexJ = w;
            while (indexI > 0 && indexJ > 0)
            {
                int a1 = arr[indexI, indexJ].Weight;
                int a2 = arr[indexI - 1, indexJ].Weight;
                if (arr[indexI, indexJ].Weight != arr[indexI - 1, indexJ].Weight ||
                    arr[indexI, indexJ].Price != arr[indexI - 1, indexJ].Price)
                {
                    autoSelect.Applications.Add(mapperApplications[indexI - 1]);
                    indexJ = indexJ - weight[indexI - 1];
                }
                indexI--;
            }

            autoSelect.Sum = arr[n, w].Weight;

            return autoSelect;
        }

        public AutoSelectionViewModel AutoSelectMaxNumber(
            List<ApplicationViewModel> mapperApplications, int sum)
        {
            AutoSelectionViewModel autoSelect = new AutoSelectionViewModel();
            for (int i = 0; i < mapperApplications.Count && autoSelect.Sum < sum; i++)
            {
                autoSelect.Sum += 
                    (double)(mapperApplications[i].RequiredSum - mapperApplications[i].CurrentSum);
                autoSelect.Applications.Add(mapperApplications[i]);
            }
            return autoSelect;
        }

        public AutoSelectionViewModel AutoSelectEndDate(
            List<ApplicationViewModel> mapperApplications, int sum)
        {
            var sortApplications = mapperApplications.Where(x => 
            x.DateTimeEnd <= DateTime.Now.AddDays(NumberOfDaysForAutoSelectAccordingEndDate)).ToList();
            AutoSelectionViewModel autoSelect = new AutoSelectionViewModel();
            if (sortApplications.Count > 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, sortApplications.Count - 1);

                autoSelect.Applications.Add(sortApplications[index]);
                if (sum < sortApplications[index].RequiredSum - sortApplications[index].CurrentSum)
                {
                    autoSelect.Sum = sum;
                }
                else
                {
                    autoSelect.Sum = (double)(
                        sortApplications[index].RequiredSum - sortApplications[index].CurrentSum);
                }
            }
            return autoSelect;
        }

        public async Task<List<AutoSelectionViewModel>> GetApplicationsForAutoPayment(AutoSelectionCreationModel value)
        {
            List<Application> unmapperApplications = await unitOfWork.ApplicationRepository
                .GetListForAutoPayment(value.CategoryIds);
            List<ApplicationViewModel> mapperApplications = mapper
                .Map<List<Application>, List<ApplicationViewModel>>(unmapperApplications);

            List<AutoSelectionViewModel> result = new List<AutoSelectionViewModel>();

            var autoSelect1 = AutoSelectWithSum(mapperApplications, (int)value.Sum);
            var autoSelect2 = AutoSelectMaxNumber(mapperApplications, (int)value.Sum);
            var autoSelect3 = AutoSelectEndDate(mapperApplications, (int)value.Sum);

            result.Add(autoSelect1);
            result.Add(autoSelect2);
            result.Add(autoSelect3);

            return result;
        }
    }
}
