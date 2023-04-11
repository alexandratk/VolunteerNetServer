﻿using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ApplicationController : ControllerBase
    {
        private IApplicationService applicationService { get; set; }

        public ApplicationController(IApplicationService applicationService)
        {
            this.applicationService = applicationService;
        }

        [Authorize(Roles = "user")]
        [HttpPost("add")]
        public async Task<ActionResult> Add([FromForm] ApplicationCreationModel value)
        {
            try
            {
                var userIdClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);
                if (userIdClaim == null)
                {
                    return BadRequest(new ValidationResult("Invalid token"));
                }

                var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);

                var validationResults = await applicationService.AddAsync(userId, value);
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

        [Authorize(Roles = "user, admin")]
        [HttpGet("getlist")]
        public async Task<ActionResult<IEnumerable<ApplicationViewModel>>> GetList([FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var applications = await applicationService.GetAllAsync(language);
                return Ok(applications);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "moderator")]
        [HttpGet("getlist/processing")]
        public async Task<ActionResult<IEnumerable<ApplicationViewModel>>> GetListForProcessing([FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var applications = await applicationService.GetListForProcessingAsync(language);
                return Ok(applications);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "user")]
        [HttpGet("getlist/currentuser")]
        public async Task<ActionResult<IEnumerable<ApplicationViewModel>>> GetListForCurrentUser([FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var userIdClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);
                if (userIdClaim == null)
                {
                    return BadRequest(new ValidationResult("Invalid token"));
                }

                var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);

                var applications = await applicationService.GetListForUserAsync(userId, language);
                return Ok(applications);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "moderator")]
        [HttpGet("approve/{applicationId}")]
        public async Task<ActionResult> ApproveApplication(Guid applicationId)
        {
            try
            {
                var validationResults = await applicationService.ApproveByModerator(applicationId);
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
    }
}