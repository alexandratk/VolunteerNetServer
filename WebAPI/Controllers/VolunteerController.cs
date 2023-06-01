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
    [Route("[controller]")]
    [Authorize]
    public class VolunteerController : ControllerBase
    {
        private IVolunteerService volunteerService { get; set; }

        public VolunteerController(IVolunteerService volunteerService)
        {
            this.volunteerService = volunteerService;
        }

        [Authorize(Roles = "user")]
        [HttpGet("add/{applicationId}")]
        public async Task<ActionResult> Add(Guid applicationId)
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

                var validationResults = await volunteerService.AddAsync(userId, applicationId);
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

        [Authorize(Roles = "admin")]
        [HttpGet("getlist")]
        public async Task<ActionResult<IEnumerable<VolunteerViewModel>>> GetList(
        [FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var volunteers = await volunteerService.GetAllAsync(language);
                return Ok(volunteers);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "user")]
        [HttpGet("getlist/inprocessing")]
        public async Task<ActionResult<IEnumerable<VolunteerViewModel>>>
            GetListInProcessingByOwnerId([FromHeader(Name = "Accept-Language")] string language)
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

                var volunteers = await volunteerService.GetListInProcessingByOwnerId(userId, language);
                return Ok(volunteers);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "user")]
        [HttpGet("getlist/chats")]
        public async Task<ActionResult<IEnumerable<VolunteerViewModel>>>
            GetListAcceptedByUserId([FromHeader(Name = "Accept-Language")] string language)
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

                var volunteers = await volunteerService.GetListWithChatsByUserId(userId, language);
                return Ok(volunteers);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "user")]
        [HttpGet("getlist/byuser")]
        public async Task<ActionResult<IEnumerable<VolunteerViewModel>>>
            GetListByUserId([FromHeader(Name = "Accept-Language")] string language)
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

                var volunteers = await volunteerService.GetListByUserId(userId, language);
                return Ok(volunteers);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "user")]
        [HttpGet("getlist/usersinchat/{applicationId}")]
        public async Task<ActionResult<ChatInformationViewModel>> GetListVolunteersInChat(
             [FromHeader(Name = "Accept-Language")] string language, Guid applicationId)
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

                var chatInfoView = await volunteerService
                    .GetListVolunteersInChat(applicationId, userId, language);
                return Ok(chatInfoView);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "user")]
        [HttpGet("accept/{volunteerId}")]
        public async Task<ActionResult> AcceptVolunteer(Guid volunteerId)
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

                var validationResults = await volunteerService.AcceptVolunteer(userId, volunteerId);
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
        [HttpPost("reject")]
        public async Task<ActionResult> RejectVolunteer([FromForm] NotificationCreationModel model)
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

                var validationResults = await volunteerService.RejectVolunteer(model, userId);
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
        [HttpPost("exit")]
        public async Task<ActionResult> ExitVolunteer([FromForm] NotificationCreationModel model)
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

                var validationResults = await volunteerService.ExitVolunteer(model, userId);
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
    }
}
