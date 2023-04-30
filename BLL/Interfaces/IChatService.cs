using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IChatService : IService<MessageCreationModel>
    {
        Task<MessageViewModel> AddAsync(Guid userId, MessageCreationModel model);

        Task<List<MessageViewModel>> GetListByApplicationId(ChatCreationModel value);
    }
}
