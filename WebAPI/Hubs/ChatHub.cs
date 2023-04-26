using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace WebAPI.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        private IChatService chatService { get; set; }

        public ChatHub(IChatService chatService)
        {
            this.chatService = chatService;
        }

        public async Task SendMessage(MessageModel message)
        {
            Debug.WriteLine("HUB1: user ==> " + message.User + "//message ==> " + message.Message);
            await chatService.Test(message);
            Debug.WriteLine("HUB2: user ==> " + message.User + "//message ==> " + message.Message);
            await Clients.All.ReceiveMessage(message);
        }
    }
}
