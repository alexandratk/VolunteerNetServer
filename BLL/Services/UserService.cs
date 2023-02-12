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

        public async Task UpdateAsync(UserModel model)
        {
            var unmapperUser = mapper.Map<UserModel, User>(model);
            await unitOfWork.UserRepository.Update(unmapperUser);
        }
    }
}
