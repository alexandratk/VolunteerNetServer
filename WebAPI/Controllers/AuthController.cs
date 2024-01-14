using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;
        private readonly IMapper mapper;

        public AuthController(IAuthService authService, IMapper mapper)
        {
            this.authService = authService;
            this.mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromForm] UserCreationModel value)
        {
            try
            {
                var validationResults = await authService.RegisterUserAsync(value);
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

        [HttpPost("auth")]
        public async Task<IActionResult> AuthUser([FromBody] AuthRequestModel authRequestModel)
        {
            var authResponse = await authService.AuthUser(authRequestModel);
            if (!authResponse.jwtToken.Equals(""))
            {
                return Ok(authResponse);
            }
            return Unauthorized();
        }

        [HttpGet("getlist/applications")]
        public async Task<ActionResult<IEnumerable<ApplicationViewModel>>> GetList(
            [FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var applications = await authService.GetAllApplicationsAsync(language);
                return Ok(applications);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpPost("verify-email")]
        public async Task<IActionResult> VerifyEmail([FromBody] EmailConfirmationModel emailConfirmationModel)
        {
            if (await authService.ValidateToken(emailConfirmationModel.Token))
            {
                return Ok();
            }
            else 
            {
                return BadRequest("Invalid verification token");
            }
        }

        [HttpGet("get/application/{applicationId}")]
        public async Task<ActionResult<ApplicationViewModel>> Get(
            [FromHeader(Name = "Accept-Language")] string language, Guid applicationId)
        {
            try
            {
                var userIdClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);

                if (userIdClaim != null)
                {
                    var userRoleClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                        x.Type == ClaimsIdentity.DefaultRoleClaimType);
                    if (userRoleClaim == null)
                    {
                        return BadRequest(new ValidationResult("Invalid token"));
                    }

                    var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);
                    var userRole = userRoleClaim.ToString().Split(": ")[1];

                    var applicationForAuth = await authService.GetApplicationByIdAuth(applicationId, userId, userRole, language);
                    return Ok(applicationForAuth);
                }

                var applicationForUnauth = await authService.GetApplicationByIdUnauth(applicationId, language);
                return Ok(applicationForUnauth);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpGet("get/document/{id}")]
        public ActionResult GetUserSkillDocument(Guid id)
        {
            var document = authService.GetApplicationDocument(id);
            return File(document.Document, document.DocumentFormat, document.Title);
        }
    }
}
