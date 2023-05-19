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
    public class LiqPayController : ControllerBase
    {
        private ILiqPayService liqPayService { get; set; }

        public LiqPayController(ILiqPayService liqPayService)
        {
            this.liqPayService = liqPayService;
        }

        //[Authorize(Roles = "user")]
        //[HttpPost("pay")]
        //public async Task<ActionResult> Add([FromForm] LiqPayCreationModel value)
        //{
        //    try
        //    {
        //        Debug.WriteLine("liq-pay data ==> " + value.Data + "\n signature ==> " + value.Signature);
        //        return Ok();
        //    }
        //    catch (Exception e)
        //    {
        //        return NotFound(e);
        //    }
        //}

        [HttpPost("createparams")]
        public async Task<ActionResult<LiqPayViewModel>> CreateParams([FromForm] LiqPayCreationModel value)
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
    }
}
