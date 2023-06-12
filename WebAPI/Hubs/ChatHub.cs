using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Claims;

namespace WebAPI.Hubs
{
    [Authorize]
    public class ChatHub : Hub<IChatClient>
    {
        private IChatService chatService { get; set; }

        public ChatHub(IChatService chatService)
        {
            this.chatService = chatService;
        }

        public async Task Enter(ChatCreationModel value)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, value.ApplicationId.ToString());
            await Groups.AddToGroupAsync(Context.ConnectionId, Context.ConnectionId.ToString());
            var messages = await chatService.GetListByApplicationId(value);
            await Clients.Group(Context.ConnectionId.ToString()).SendListAsync(messages);
        }

        public async Task SendMessage(MessageCreationModel value)
        {
            var userIdClaim = Context.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);

            var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);
            var message = await chatService.AddAsync(userId, value);
            await Clients.Group(value.ApplicationId.ToString()).ReceiveMessage(message);
        }
    }
}
