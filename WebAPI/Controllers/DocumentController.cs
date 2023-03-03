using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private IUserService userService { get; set; }

        public DocumentController(IUserService userService)
        {
            this.userService = userService;
        }

        //[HttpGet("document/{id}")]
        //public ActionResult GetById(Guid id)
        //{

        //    var document = userService.GetFile(id);
        //    return File(document.Document, document.DocumentFormat, "myfile");

        //}
    }
}
