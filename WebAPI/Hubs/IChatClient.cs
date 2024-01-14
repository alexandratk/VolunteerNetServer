using BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Hubs
{
    public interface IChatClient
    {
        Task SendListAsync(IEnumerable<MessageViewModel> messageViewModels);
        Task ReceiveMessage(MessageViewModel message);
    }
}
