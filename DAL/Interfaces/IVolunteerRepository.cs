using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IVolunteerRepository : IRepository<Volunteer>
    {
        Task DeleteByApplicationId(Guid applicationId);

        Task<Volunteer?> GetByUserIdApplicationId(Guid userId, Guid applicationId);

        Task<Volunteer?> GetByUserIdApplicationIdWithoutForeign(Guid userId, Guid applicationId);

        Task<Volunteer?> GetByIdWithoutForeignAsync(Guid id);

        Task<List<Volunteer>> GetListByUserId(Guid userId);

        Task<List<Volunteer>> GetListByUserIdAceptedCompleted(Guid userId);

        Task<List<Volunteer>> GetListInProcessingByOwnerId(Guid userId);

        Task<List<Volunteer>> GetListVolunteersInChat(Guid applicationId);

        Task<List<Volunteer>> GetListVolunteersInChatWithoutForeign(Guid applicationId);

        Task<List<Volunteer>> GetListWithChatsByUserId(Guid userId);
    }
}
