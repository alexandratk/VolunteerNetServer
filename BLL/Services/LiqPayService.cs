using BLL.Interfaces;
using BLL.Models;
using DAL.DefaultData;
using LiqPay.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LiqPayService : ILiqPayService
    {

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
