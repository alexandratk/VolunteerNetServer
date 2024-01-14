using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

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

        [Authorize(Roles = "user, admin, moderator")]
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                var userIdClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);
                if (userIdClaim == null)
                {
                    return BadRequest(new ValidationResult("Invalid token"));
                }

                var userRoleClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                        x.Type == ClaimsIdentity.DefaultRoleClaimType);
                if (userRoleClaim == null)
                {
                    return BadRequest(new ValidationResult("Invalid token"));
                }

                var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);
                var userRole = userRoleClaim.ToString().Split(": ")[1];
                await applicationService.DeleteAsync(id, userId, userRole);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "user, admin, moderator")]
        [HttpGet("getlist")]
        public async Task<ActionResult<IEnumerable<ApplicationViewModel>>> GetList(
            [FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var userRoleClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultRoleClaimType);
                if (userRoleClaim == null)
                {
                    return BadRequest(new ValidationResult("Invalid token"));
                }

                var userRole = userRoleClaim.ToString().Split(": ")[1];

                Debug.WriteLine("user role ==> " + userRole);

                var applications = await applicationService.GetAllAsync(userRole, language);
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

        [Authorize(Roles = "admin, moderator")]
        [HttpGet("approve/{applicationId}")]
        public async Task<ActionResult> ApproveApplication(Guid applicationId)
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

                var validationResults = await applicationService.ApproveApplication(applicationId, userId);
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

        [Authorize(Roles = "admin, moderator")]
        [HttpPost("forbid")]
        public async Task<ActionResult> ForbidApplication([FromForm] NotificationCreationModel value)
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

                var validationResults = await applicationService.ForbidApplication(value, userId);
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

        [Authorize(Roles = "user")]
        [HttpGet("complete/{applicationId}")]
        public async Task<ActionResult> CompleteApplication(Guid applicationId)
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

                var validationResults = await applicationService.CompleteApplication(applicationId, userId);
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
