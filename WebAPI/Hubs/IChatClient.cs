using BLL.Models;

namespace WebAPI.Hubs
{
    public interface IChatClient
    {
        Task SendAsync(string message);
        Task ReceiveMessage(MessageCreationModel message);
    }
}
