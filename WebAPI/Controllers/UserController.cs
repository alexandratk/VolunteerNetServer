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

        [HttpPost]
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

        // PUT: api/user/1
        [HttpPut("{id}")]
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

        // DELETE: api/user/1
        [HttpDelete("{id}")]
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

        // GET: api/user
        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> Get()
        {
                var customers = await userService.GetAllAsync();
                return Ok(customers);

        }

        //GET: api/user/1
        [HttpGet("{id}")]
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
