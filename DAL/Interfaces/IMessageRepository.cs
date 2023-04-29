using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IMessageRepository : IRepository<Message>
    {
        Task<List<Message>> GetListByApplicationIdAsync(Guid applicationId);
    }
}
