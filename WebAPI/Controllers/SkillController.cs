
using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkillController : ControllerBase
    {
        private ISkillService skillService { get; set; }

        public SkillController(ISkillService skillService)
        {
            this.skillService = skillService;
        }

        [HttpPost("add")]
        public async Task<ActionResult> Add([FromBody] SkillModel value)
        {
            try
            {
                await skillService.AddAsync(value);
                return Ok();
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

        [HttpGet("getlist")]
        public async Task<ActionResult<IEnumerable<SkillModel>>> GetList()
        {
            try
            {
                var customers = await skillService.GetAllAsync();
                return Ok(customers);
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
