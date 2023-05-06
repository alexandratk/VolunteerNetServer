using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
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
    public class CategoryController : ControllerBase
    {
        private ICategoryService categoryService { get; set; }

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [Authorize(Roles = "user, admin")]
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
