﻿using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ILiqPayService : IService<LiqPayModel>
    {
        Task<List<ValidationResult>> AddAsync(LiqPayModel value);

        Task<LiqPayViewModel> CreateParams(LiqPayCreationModel liqPayCreationModel);

        Task<LiqPayViewModel> CreateParamsAutoPayment(
            LiqPayAutoPaymentCreationModel liqPayAutoPaymentCreationModel);

        Task<List<AutoSelectionViewModel>> GetApplicationsForAutoPayment(
            AutoSelectionCreationModel value);

        Task<List<LiqPayDonatesViewModel>> GetListDonates(int numberOfDays, string language);

        Task<LiqPayApplicationViewModel> GetApplicationDonations(
            Guid applicationId, string language);
    }
}
