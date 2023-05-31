using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private ICategoryService categoryService { get; set; }

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [Authorize(Roles = "admin")]
        [HttpPost("add/category")]
        public async Task<ActionResult> Add([FromForm] CategoryCreationModel value)
        {
            try
            {
                var validationResults = await categoryService.AddAsync(value);
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

        [AllowAnonymous]
        [HttpGet("getlist")]
        public async Task<ActionResult<IEnumerable<CategoryModel>>> GetList(
            [FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var categories = await categoryService.GetAllAsync(language);
                return Ok(categories);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
    }
}
