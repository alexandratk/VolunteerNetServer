using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ChatService : IChatService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public ChatService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }


        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MessageModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MessageModel model)
        {
            throw new NotImplementedException();
        }

        public Task<MessageModel> Test(MessageModel value)
        {
            Debug.WriteLine("SERVICE: user ==> " + value.User + "//message ==> " + value.Message);
            return Task.FromResult(value);
        }
    }
}
