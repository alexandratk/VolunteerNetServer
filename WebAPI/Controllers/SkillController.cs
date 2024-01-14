
using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class SkillController : ControllerBase
    {
        private ISkillService skillService { get; set; }

        public SkillController(ISkillService skillService)
        {
            this.skillService = skillService;
        }

        [Authorize(Roles = "admin")]
        [HttpPost("add/skill")]
        public async Task<ActionResult> Add([FromForm] SkillCreationModel value)
        {
            try
            {
                var validationResults = await skillService.AddAsync(value);
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

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                await skillService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [AllowAnonymous]
        [HttpGet("getlist")]
        public async Task<ActionResult<IEnumerable<SkillModel>>> GetList([FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var skills = await skillService.GetAllAsync(language);
                return Ok(skills);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "user")]
        [HttpGet("getlistbyid")]
        public async Task<ActionResult<IEnumerable<SkillModel>>> GetListByUserId([FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var userId = HttpContext.User.Claims.FirstOrDefault(x => 
                    x.Type == ClaimsIdentity.DefaultNameClaimType).ToString().Split(": ")[1];
                var skills = await skillService.GetListByUserIdAsync(Guid.Parse(userId), language);
                return Ok(skills);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<SkillModel>> GetById(Guid id)
        {
            try
            {
                var customer = await skillService.GetByIdAsync(id);
                return Ok(customer);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult> Update(Guid Id, [FromBody] SkillModel value)
        {
            try
            {
                await skillService.UpdateAsync(value);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
    }
}
