using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class LiqPayController : ControllerBase
    {
        private IApplicationService applicationService { get; set; }

        public LiqPayController(IApplicationService applicationService)
        {
            this.applicationService = applicationService;
        }

        [Authorize(Roles = "user")]
        [HttpPost("pay")]
        public async Task<ActionResult> Add([FromForm] LiqPayCreationModel value)
        {
            try
            {
                Debug.WriteLine("liq-pay data ==> " + value.Data + "\n signature ==> " + value.Signature);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
    }
}
