using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult> Register([FromBody] UserModel value)
        {
            try
            {
                await authService.RegisterAsync(value);
                return Ok();
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

            return Ok(authResponse);
        }
    }
}
