using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseModel> AuthUser(AuthRequestModel authRequestModel);

        Task RegisterAsync(UserModel model);
    }
}
