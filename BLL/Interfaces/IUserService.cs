﻿using BLL.Models;
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
        
        Task<List<ValidationResult>> DeleteUserSkillsAsync(Guid userId, Guid skillId);
        
        Task<IEnumerable<UserViewModel>> GetAllAsync(string language);

        Task<UserViewModel> GetByIdAsync(Guid id);
        
        Task<UserViewModel> GetByIdAsync(Guid id, string language);
        
        DocumentModel GetUserSkillDocument(Guid id);

        Task<List<ValidationResult>> UpdateProfilePictureAsync(Guid id, ProfilePictureCreationModel model);

        Task<List<ValidationResult>> UpdateUserSkillsAsync(Guid userId, UserSkillCreationModel model);
        
        
    }
}
