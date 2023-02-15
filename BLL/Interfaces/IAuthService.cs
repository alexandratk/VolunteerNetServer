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

        Task<List<ValidationResult>> RegisterUserAsync(UserCreatingModel model);
    }
}
