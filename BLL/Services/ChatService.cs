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

        public async Task<MessageViewModel> AddAsync(Guid userId, MessageCreationModel model)
        {
            var validationResults = new List<ValidationResult>();
            var volunteer = await unitOfWork.VolunteerRepository.GetByUserIdApplicationId(userId, model.ApplicationId);

            var mapperMessage = mapper.Map<MessageCreationModel, Message>(model);
            mapperMessage.Id = Guid.NewGuid();
            mapperMessage.DateTime = DateTime.Now;
            mapperMessage.VolunteerId = volunteer.Id;
            mapperMessage.VolunteerUserId = volunteer.UserId;
            mapperMessage.VolunteerApplicationId = volunteer.ApplicationId;
            Debug.WriteLine("SERVICE: " + "//message ==> " + model.Text);
            await unitOfWork.MessageRepository.AddAsync(mapperMessage);

            MessageViewModel messageView = new MessageViewModel();
            messageView.Id = mapperMessage.Id;
            messageView.Text = mapperMessage.Text;
            messageView.DateTime = mapperMessage.DateTime;
            messageView.FirstName = volunteer.User.FirstName;
            messageView.LastName = volunteer.User.LastName;
            return messageView;
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MessageCreationModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MessageViewModel>> GetListByApplicationId(ChatCreationModel value)
        {
            var unmapperMessages = await unitOfWork.MessageRepository.GetListByApplicationIdAsync(value.ApplicationId);
            var mapperMessages = mapper
                .Map<IEnumerable<Message>, IEnumerable<MessageViewModel>>(unmapperMessages);
            return mapperMessages;
        }

        public Task UpdateAsync(MessageCreationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
