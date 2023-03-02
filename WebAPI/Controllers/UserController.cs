using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private IUserService userService { get; set; }

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [Authorize(Roles = "admin")]
        [HttpPost("adduser")]
        public async Task<ActionResult> Register([FromForm] UserModel value)
        {
            try
            {
                var validationResults = await userService.AddUserAsync(value);
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

        //[HttpPost("addlist")]
        //public async Task<ActionResult> AddList([FromBody] List<UserModel> value)
        //{
        //    for (int i = 0; i < value.Count; i++)
        //    {
        //        try
        //        {
        //            await userService.AddAsync(value[i]);
        //        }
        //        catch (Exception e)
        //        {
        //            return NotFound(e);
        //        }
        //    }
        //    return Ok();
        //}

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

        [Authorize(Roles = "user, admin")]
        [HttpPost("update/profilepicture")]
        public async Task<ActionResult> UpdateProfilePictureByIdFromToken([FromForm] ProfilePictureCreatingModel value)
        {
            try
            {
                var userId = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType).ToString().Split(": ")[1];

                var validationResults = await userService.UpdateProfilePictureAsync(Guid.Parse(userId), value);
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
        public async Task<ActionResult<IEnumerable<UserViewModel>>> GetList([FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var customers = await userService.GetAllAsync(language);
                return Ok(customers);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpGet("getbyid/{id}")]
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

        //[Authorize(Roles = "user, admin")]
        //[HttpGet("get/{language}")]
        //public async Task<ActionResult<UserModel>> GetByIdFromToken(string language)
        //{
        //    try
        //    {
        //        var userId = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimsIdentity.DefaultNameClaimType).ToString().Split(": ")[1];
        //        var customer = await userService.GetByIdAsync(Guid.Parse(userId), language);
        //        return Ok(customer);
        //    }
        //    catch (Exception e)
        //    {
        //        return NotFound(e);
        //    }
        //}

        [Authorize(Roles = "user, admin")]
        [HttpGet("get")]
        public async Task<ActionResult<UserModel>> GetByIdFromToken([FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var userId = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimsIdentity.DefaultNameClaimType).ToString().Split(": ")[1];
                var customer = await userService.GetByIdAsync(Guid.Parse(userId), language);
                return Ok(customer);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
    }
}
