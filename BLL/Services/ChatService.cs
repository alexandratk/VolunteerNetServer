using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public async Task<List<ValidationResult>> AddAsync(Guid userId, MessageCreationModel model)
        {
            var validationResults = new List<ValidationResult>();
            var volunteer = await unitOfWork.VolunteerRepository.GetByUserIdApplicationId(userId, model.ApplicationId);
            if (volunteer == null) 
            {
                validationResults.Add(new ValidationResult("invalidApplicationIdOrUserId"));
                return validationResults;
            }
            var mapperMessage = mapper.Map<MessageCreationModel, Message>(model);
            mapperMessage.Id = Guid.NewGuid();
            mapperMessage.VolunteerId = volunteer.Id;
            Debug.WriteLine("SERVICE: " + "//message ==> " + model.Text);
            await unitOfWork.MessageRepository.AddAsync(mapperMessage);
            return validationResults;
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MessageCreationModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(MessageCreationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
