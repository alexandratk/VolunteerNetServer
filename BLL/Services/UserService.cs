using AutoMapper;
using BLL.Helpers;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public async Task AddAsync(UserModel model)
        {
            model.Password = HashHelper.ComputeSha256Hash(model.Password);
            var mapperUser = mapper.Map<UserModel, User>(model);
            await unitOfWork.UserRepository.AddAsync(mapperUser);
            await unitOfWork.SaveAsync();
        }

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

        public async Task<UserModel> GetByIdAsync(Guid id)
        {
            var unmapperUser = await unitOfWork.UserRepository.GetByIdAsync(id);
            if (unmapperUser != null)
            {
                var mapperUser = mapper.Map<User, UserModel>(unmapperUser);
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
