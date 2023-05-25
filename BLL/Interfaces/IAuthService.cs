using BLL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseModel> AuthUser(AuthRequestModel authRequestModel);

        Task<List<ApplicationViewModel>> GetAllApplicationsAsync(string language);

        Task<ApplicationViewModel> GetApplicationById(Guid applicationId, string language);

        Task<ApplicationViewModel> GetApplicationByIdAuth(
            Guid applicationId, Guid userId, string userRole, string language);

        Task<ApplicationViewModel> GetApplicationByIdUnauth(Guid applicationId, string language);

        DocumentModel GetApplicationDocument(Guid id);

        Task<List<ValidationResult>> RegisterUserAsync(UserCreationModel model);
    }
}
