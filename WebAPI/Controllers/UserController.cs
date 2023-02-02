using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BLL.Helpers;
using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService userService { get; set; }

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("add")]
        public async Task<ActionResult> Add([FromBody] UserModel value)
        {
            value.Password = HashHelper.ComputeSha256Hash(value.Password);
            try
            {
                await userService.AddAsync(value);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpPost("addlist")]
        public async Task<ActionResult> AddList([FromBody] List<UserModel> value)
        {
            for (int i = 0; i < value.Count; i++)
            {
                value[i].Password = HashHelper.ComputeSha256Hash(value[i].Password);
                try
                {
                    await userService.AddAsync(value[i]);
                }
                catch (Exception e)
                {
                    return NotFound(e);
                }
            }
            return Ok();
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult> Update(Guid Id, [FromBody] UserModel value)
        {
            try
            {
                await userService.UpdateAsync(value);
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
                await userService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "admin")]
        [HttpGet("getlist")]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetList()
        {
                var customers = await userService.GetAllAsync();
                return Ok(customers);

        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<UserModel>> GetById(Guid id)
        {
            try
            {
                var customer = await userService.GetByIdAsync(id);
                return Ok(customer);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
    }
}
