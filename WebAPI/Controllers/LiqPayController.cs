﻿using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LiqPayController : ControllerBase
    {
        private ILiqPayService liqPayService { get; set; }

        public LiqPayController(ILiqPayService liqPayService)
        {
            this.liqPayService = liqPayService;
        }

        [HttpPost("createparams")]
        public async Task<ActionResult<LiqPayViewModel>> CreateParams(
            [FromForm] LiqPayCreationModel value)
        {
            try
            {
                LiqPayViewModel liqPayViewModel = await liqPayService.CreateParams(value);
                return Ok(liqPayViewModel);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpPost("createparams/auto")]
        public async Task<ActionResult<LiqPayViewModel>> CreateParamsAutoPayment(
            [FromForm] LiqPayAutoPaymentCreationModel value)
        {
            try
            {
                LiqPayViewModel liqPayViewModel = await liqPayService.CreateParamsAutoPayment(value);
                return Ok(liqPayViewModel);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpPost("donate")]
        public async Task<ActionResult> Add([FromForm] LiqPayModel value)
        {
            try
            {
                var validationResults = await liqPayService.AddAsync(value);

                if (validationResults.IsNullOrEmpty())
                {
                    return Ok();
                }
                return BadRequest(validationResults);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpPost("getlist/autodonate")]
        public async Task<ActionResult<IEnumerable<AutoSelectionViewModel>>> GetListAutoDonate(
            [FromForm] AutoSelectionCreationModel value)
        {
            try
            {
                var applications = await liqPayService.GetApplicationsForAutoPayment(value);
                return Ok(applications);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpGet("getlist/donates/{numberOfDays}")]
        public async Task<ActionResult<IEnumerable<AutoSelectionViewModel>>> GetListDonates(
            [FromHeader(Name = "Accept-Language")] string language, int numberOfDays)
        {
            try
            {
                var applications = await liqPayService.GetListDonates(numberOfDays, language);
                return Ok(applications);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpGet("get/application/{applicationId}")]
        public async Task<ActionResult<LiqPayApplicationViewModel>> GetApplicationDonations(
            [FromHeader(Name = "Accept-Language")] string language, Guid applicationId)
        {
            try
            {
                var application = await liqPayService.GetApplicationDonations(applicationId, language);
                return Ok(application);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
    }
}
