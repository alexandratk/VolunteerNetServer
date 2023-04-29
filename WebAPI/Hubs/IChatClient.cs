using BLL.Models;

namespace WebAPI.Hubs
{
    public interface IChatClient
    {
        Task SendListAsync(IEnumerable<MessageViewModel> messageViewModels);
        Task ReceiveMessage(MessageViewModel message);
    }
}
