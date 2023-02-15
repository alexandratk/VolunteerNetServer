using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService : IService<UserModel>
    {
        Task<UserViewModel> GetByIdAsync(Guid id);

        Task<List<ValidationResult>> UpdateProfilePictureAsync(Guid id, ProfilePictureCreatingModel model);
    }
}
