using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Data;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using LiqPay.SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LiqPayService : ILiqPayService
    {
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

            var applicationId = Guid.Parse(value.Description);

            var application = await unitOfWork.ApplicationRepository.GetByIdAsync(applicationId);

            if (application == null)
            {
                validationResults.Add(new ValidationResult("applicationIdIsWrong"));
                return validationResults;
            }

            var mapperDonate = mapper.Map<LiqPayModel, Donate>(value);
            mapperDonate.Id = Guid.NewGuid();
            mapperDonate.DateTimeCreation = DateTime.Now;
            mapperDonate.ApplicationId = applicationId;

            await unitOfWork.DonateRepository.AddAsync(mapperDonate);

            application.CurrentSum += (decimal)mapperDonate.Amount;

            await unitOfWork.ApplicationRepository.Update(application);

            return validationResults;
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LiqPayModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LiqPayViewModel> CreateParams(LiqPayCreationModel liqPayCreationModel)
        {
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
                OrderId = Guid.NewGuid().ToString()
            });

            liqPayViewModel.Data = data.Key;
            liqPayViewModel.Signature = data.Value;

            return Task.FromResult(liqPayViewModel);
        }

        public Task UpdateAsync(LiqPayModel model)
        {
            throw new NotImplementedException();
        }
    }
}
