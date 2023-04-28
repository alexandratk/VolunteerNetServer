using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
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

        public async Task SendMessage(MessageCreationModel message)
        {
            var userIdClaim = Context.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);

            var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);
            Debug.WriteLine("context ==> " + userIdClaim.ToString().Split(": ")[1]);
            Debug.WriteLine("HUB1: " + "//message ==> " + message.Text);
            await chatService.AddAsync(userId, message);
            Debug.WriteLine("HUB2: " + "//message ==> " + message.Text);
            await Clients.All.ReceiveMessage(message);
        }
    }
}
