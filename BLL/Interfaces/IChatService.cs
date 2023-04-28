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
        Task<List<ValidationResult>> AddAsync(Guid userId, MessageCreationModel model);
    }
}
