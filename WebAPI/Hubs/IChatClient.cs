using BLL.Models;

namespace WebAPI.Hubs
{
    public interface IChatClient
    {
        Task ReceiveMessage(MessageCreationModel message);
    }
}
