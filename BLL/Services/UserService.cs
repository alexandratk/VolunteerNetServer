using AutoMapper;
using BLL.Helpers;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        private const int DefaultProfilePictureLength = 256000;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        //public string findDefaultProfilePictureFormat()
        //{
        //    var pathAfterSplit = DefaultProfilePicturePath.Split('.');
        //    string format = "image/" + pathAfterSplit[pathAfterSplit.Length - 1];
        //    return format;
        //}

        public async Task DeleteAsync(Guid modelId)
        {
            var unmapperUser = await unitOfWork.UserRepository.GetByIdAsync(modelId);
            if (unmapperUser != null)
            {
                await unitOfWork.UserRepository.DeleteAsync(unmapperUser);
            }
        }

        public async Task<IEnumerable<UserModel>> GetAllAsync()
        {
            var unmapperUsers = await unitOfWork.UserRepository.GetAllAsync();
            var mapperUsers = mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(unmapperUsers);
            return mapperUsers;
        }

        public async Task<UserViewModel> GetByIdAsync(Guid id)
        {
            var unmapperUser = await unitOfWork.UserRepository.GetByIdAsync(id);
            if (unmapperUser != null)
            {
                var mapperUser = mapper.Map<User, UserViewModel>(unmapperUser);
                if (unmapperUser.ProfilePicture != null)
                {
                    mapperUser.ProfilePicture = Convert.ToBase64String(unmapperUser.ProfilePicture.Data);
                }
                // else
                //{
                //    mapperUser.ProfilePicture = "";
                //    //byte[] profilePictureBytes = File.ReadAllBytes(DefaultProfilePicturePath);
                //    //mapperUser.ProfilePicture = Convert.ToBase64String(profilePictureBytes);
                //    //mapperUser.ProfilePictureFormat = findDefaultProfilePictureFormat();
                //}
                return mapperUser;
            }
            return null;
        }

        public async Task<List<ValidationResult>> UpdateProfilePictureAsync(Guid userId, ProfilePictureCreatingModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (model.ProfilePicture != null &&
                model.ProfilePicture.Length > DefaultProfilePictureLength)
            {
                validationResults.Add(new ValidationResult("Invalid profile picture"));
                return validationResults;
            }

            if (model.ProfilePicture != null)
            {
                ProfilePicture newProfilePicture = new ProfilePicture();

                newProfilePicture.UserId = userId;
                newProfilePicture.Format = model.ProfilePicture.ContentType;

                var memoryStream = new MemoryStream();
                model.ProfilePicture.CopyTo(memoryStream);
                newProfilePicture.Data = memoryStream.ToArray();
                
                var currentProfilePicture = await unitOfWork.ProfilePictureRepository.GetByUserIdAsync(userId);
                if (currentProfilePicture == null)
                {
                    newProfilePicture.Id = Guid.NewGuid();
                    await unitOfWork.ProfilePictureRepository.AddAsync(newProfilePicture);
                } else
                {
                    newProfilePicture.Id = currentProfilePicture.Id;
                    await unitOfWork.ProfilePictureRepository.Update(newProfilePicture);
                }
                
            }
            return validationResults;
        }

        public async Task UpdateAsync(UserModel model)
        {
            var unmapperUser = mapper.Map<UserModel, User>(model);
            await unitOfWork.UserRepository.Update(unmapperUser);
        }
    }
}
