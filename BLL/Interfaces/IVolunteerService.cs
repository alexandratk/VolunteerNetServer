using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IVolunteerService : IService<VolunteerModel>
    {
        Task<List<ValidationResult>> AddAsync(Guid userId, Guid applicationId);

        Task<List<ValidationResult>> AcceptVolunteer(Guid userId, Guid volunteerId);

        Task<List<ValidationResult>> DeleteAsync(Guid volunteerId, Guid userId);

        Task<List<ValidationResult>> ExitVolunteer(NotificationCreationModel model, Guid userId);

        Task<IEnumerable<VolunteerViewModel>> GetAllAsync(string language);

        Task<IEnumerable<VolunteerViewModel>> GetListByUserId(Guid userId, string language);

        Task<IEnumerable<VolunteerViewModel>> GetListInProcessingByOwnerId(Guid userId, string language);

        Task<IEnumerable<VolunteerViewModel>> GetListVolunteersInChat(
            Guid applicationId, Guid userId, string language);

        Task<IEnumerable<VolunteerViewModel>> GetListWithChatsByUserId(Guid userId, string language);

        Task<List<ValidationResult>> RejectVolunteer(NotificationCreationModel model, Guid userId);
    }
}
