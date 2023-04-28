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

        public async Task Enter(ChatCreationModel value)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, value.ApplicationId.ToString());
            MessageCreationModel messageCreationModel = new MessageCreationModel();
            messageCreationModel.Text = $"{value.ApplicationId.ToString()} вошел в чат";
            await Clients.Group(value.ApplicationId.ToString()).ReceiveMessage(messageCreationModel);
        }

        public async Task SendMessage(MessageCreationModel value)
        {
            var userIdClaim = Context.User.Claims.FirstOrDefault(x =>
                    x.Type == ClaimsIdentity.DefaultNameClaimType);

            var userId = Guid.Parse(userIdClaim.ToString().Split(": ")[1]);
            Debug.WriteLine("context ==> " + userIdClaim.ToString().Split(": ")[1]);
            Debug.WriteLine("HUB1: " + "//message ==> " + value.Text);
            await chatService.AddAsync(userId, value);
            Debug.WriteLine("HUB2: " + "//message ==> " + value.Text);
            await Clients.Group(value.ApplicationId.ToString()).ReceiveMessage(value);
        }
    }
}
