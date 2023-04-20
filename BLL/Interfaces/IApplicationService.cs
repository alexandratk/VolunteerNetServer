using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IApplicationService : IService<ApplicationModel>
    {
        Task<List<ValidationResult>> AddAsync(Guid userId, ApplicationCreationModel model);

        Task<List<ValidationResult>> ApproveByModerator(Guid applicationId);

        Task<IEnumerable<ApplicationViewModel>> GetAllAsync(string language);

        Task<ApplicationViewModel> GetByIdAsync(Guid applicationId, string language);

        Task<IEnumerable<ApplicationViewModel>> GetListForProcessingAsync(string language);

        Task<IEnumerable<ApplicationViewModel>> GetListForUserAsync(Guid userId, string language);
    }
}
