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
using Newtonsoft.Json.Linq;

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
        public async Task<ActionResult> AddUser([FromForm] UserModel value)
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

        [Authorize(Roles = "user, admin, moderator")]
        [HttpPost("update/profilepicture")]
        public async Task<ActionResult> UpdateProfilePictureByIdFromToken([FromForm] ProfilePictureCreationModel value)
        {
            try
            {
                var userIdClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);
                if (userIdClaim == null)
                {
                    return BadRequest(new ValidationResult("Invalid token"));
                }

                var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);

                var validationResults = await userService.UpdateProfilePictureAsync(userId, value);
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

        [Authorize(Roles = "user, admin, moderator")]
        [HttpDelete("delete/profilepicture")]
        public async Task<ActionResult> DeleteProfilePictureByIdFromToken()
        {
            try
            {
                var userIdClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);
                if (userIdClaim == null)
                {
                    return BadRequest(new ValidationResult("Invalid token"));
                }

                var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);

                var validationResults = await userService.DeleteProfilePictureAsync(userId);
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

        [Authorize(Roles = "user")]
        [HttpPost("update/skill")]
        public async Task<ActionResult> UpdateSkillsByIdFromToken([FromForm] UserSkillCreationModel value)
        {
            try
            {
                var userIdClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);
                if (userIdClaim == null)
                {
                    return BadRequest(new ValidationResult("Invalid token"));
                }

                var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);

                var validationResults = await userService.UpdateUserSkillsAsync(userId, value);
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

        [Authorize(Roles = "user")]
        [HttpDelete("delete/skill/{skillId}")]
        public async Task<ActionResult> DeleteSkillsByIdFromToken(Guid skillId)
        {
            try
            {
                var userIdClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);
                if (userIdClaim == null)
                {
                    return BadRequest(new ValidationResult("Invalid token"));
                }

                var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);

                var validationResults = await userService.DeleteUserSkillsAsync(userId, skillId);
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

        [Authorize(Roles = "user, admin, moderator")]
        [HttpGet("getbyid/{userId}")]
        public async Task<ActionResult<UserModel>> GetById([FromHeader(Name = "Accept-Language")] string language, Guid userId)
        {
            try 
            { 
                var customer = await userService.GetByIdAsync(userId, language);
                return Ok(customer);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "user, admin, moderator")]
        [HttpGet("get")]
        public async Task<ActionResult<UserModel>> GetByIdFromToken([FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var userIdClaim = HttpContext.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);
                if (userIdClaim == null)
                {
                    return BadRequest(new ValidationResult("Invalid token"));
                }

                var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);
                var customer = await userService.GetByIdAsync(userId, language);
                return Ok(customer);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }


        [Authorize(Roles = "user, admin, moderator")]
        [HttpGet("getskilldocument/{id}")]
        public ActionResult GetUserSkillDocument(Guid id)
        {
            var document = userService.GetUserSkillDocument(id);
            return File(document.Document, document.DocumentFormat, "file");
        }
    }
}
