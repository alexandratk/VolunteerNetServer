using BLL.Models;
using Microsoft.AspNetCore.Mvc;
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
        Task<List<ValidationResult>> AddUserAsync(UserModel model);

        Task<UserViewModel> GetByIdAsync(Guid id);
        
        Task<UserViewModel> GetByIdAsync(Guid id, string language);

        Task<IEnumerable<UserViewModel>> GetAllAsync(string language);

        Task<List<ValidationResult>> UpdateProfilePictureAsync(Guid id, ProfilePictureCreatingModel model);

        Task<List<ValidationResult>> UpdateUserSkillsAsync(Guid userId, UserSkillCreatingModel model);


        DocumentModel GetUserSkillDocument(Guid id);
    }
}
