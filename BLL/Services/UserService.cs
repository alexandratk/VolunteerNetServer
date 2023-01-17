using AutoMapper;
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
            var mapperUser = mapper.Map<UserModel, User>(model);
            await unitOfWork.UserRepository.AddAsync(mapperUser);
            await unitOfWork.SaveAsync();
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserModel>> GetAllAsync()
        {
            var unmapperUsers = await unitOfWork.UserRepository.GetAllAsync();
            var mapperUsers = mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(unmapperUsers);
            return mapperUsers;
        }

        public Task<UserModel> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
