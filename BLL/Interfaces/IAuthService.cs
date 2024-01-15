using BLL.Models;
using System.ComponentModel.DataAnnotations;

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

        Task<bool> SendResetPasswordLink(string email);

        Task<bool> ResetPassword(ResetPasswordModel resetPasswordModel);

        Task<bool> ValidateEmailConfirmationToken(string token);
    }
}
