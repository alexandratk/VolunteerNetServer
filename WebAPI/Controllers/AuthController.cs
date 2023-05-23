using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Security.Claims;

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
    }
}
