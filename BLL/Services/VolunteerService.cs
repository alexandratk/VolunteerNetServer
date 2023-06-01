using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class VolunteerService : IVolunteerService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public VolunteerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ValidationResult>> AddAsync(Guid userId, Guid applicationId)
        {
            var validationResults = new List<ValidationResult>();
            if (applicationId == null)
            {
                validationResults.Add(new ValidationResult("applicationIdIsEmpty"));
                return validationResults;
            }
            var application = await unitOfWork.ApplicationRepository.GetByIdAsync(applicationId);
            if (application == null)
            {
                validationResults.Add(new ValidationResult("incorrectApplicationId"));
                return validationResults;
            }
            if (application.UserId == userId)
            {
                validationResults.Add(new ValidationResult("userIsOwner"));
                return validationResults;
            }
            if (application.NumberOfVolunteers == application.RequiredNumberOfVolunteers)
            {
                validationResults.Add(new ValidationResult("recruitedRequiredNumberVolunteers"));
                return validationResults;
            }
            var volunteer = await unitOfWork.VolunteerRepository.GetByUserIdApplicationId(userId, applicationId);
            if (volunteer != null)
            {
                validationResults.Add(new ValidationResult("userIsVolunteerAlready"));
                return validationResults;
            }

            Volunteer mapperVolunteer = new Volunteer();
            mapperVolunteer.Id = Guid.NewGuid();
            mapperVolunteer.UserId = userId;
            mapperVolunteer.ApplicationId = applicationId;
            mapperVolunteer.Status = (int)VolunteerStatuses.Status.Processing;
            mapperVolunteer.CreationDateTime = DateTime.Now;

            await unitOfWork.VolunteerRepository.AddAsync(mapperVolunteer);

            return validationResults;
        }

        public async Task<List<ValidationResult>> DeleteAsync(Guid volunteerId, Guid userId)
        {
            var validationResults = new List<ValidationResult>();
            if (volunteerId == null)
            {
                validationResults.Add(new ValidationResult("volunteerIdIsEmpty"));
                return validationResults;
            }
            var volunteer = await unitOfWork.VolunteerRepository.GetByIdAsync(volunteerId);
            if (volunteer == null)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerId"));
                return validationResults;
            }
            if (volunteer.Application.UserId != userId)
            {
                validationResults.Add(new ValidationResult("userIsNotOwner"));
                return validationResults;
            }
            if (volunteer.UserId == userId)
            {
                validationResults.Add(new ValidationResult("volunteerIsOwner"));
                return validationResults;
            }

            await unitOfWork.VolunteerRepository.DeleteAsync(volunteer);

            return validationResults;
        }

        public async Task<IEnumerable<VolunteerViewModel>> GetAllAsync(string language)
        {
            IEnumerable<Volunteer> unmapperVolunteers = await unitOfWork.VolunteerRepository.GetAllAsync();
            var mapperVolunteers = mapper
                .Map<IEnumerable<Volunteer>, IEnumerable<VolunteerViewModel>>(unmapperVolunteers);

            foreach (var volunteer in mapperVolunteers)
            {
                var translation = VolunteerStatuses.StatusTranslation[volunteer.StatusNumber];
                volunteer.Status = translation[language];
            }
            return mapperVolunteers;
        }

        public async Task<IEnumerable<VolunteerViewModel>> GetListInProcessingByOwnerId(
            Guid userId, string language)
        {
            IEnumerable<Volunteer> unmapperVolunteers = await unitOfWork.VolunteerRepository
                .GetListInProcessingByOwnerId(userId);
            var mapperVolunteers = mapper
                .Map<IEnumerable<Volunteer>, IEnumerable<VolunteerViewModel>>(unmapperVolunteers);

            foreach (var volunteer in mapperVolunteers)
            {
                var translation = VolunteerStatuses.StatusTranslation[volunteer.StatusNumber];
                volunteer.Status = translation[language];
            }
            return mapperVolunteers;
        }

        public async Task<IEnumerable<VolunteerViewModel>> GetListByUserId(
            Guid userId, string language)
        {
            IEnumerable<Volunteer> unmapperVolunteers = await unitOfWork.VolunteerRepository
                .GetListByUserId(userId);
            var mapperVolunteers = mapper
                .Map<IEnumerable<Volunteer>, IEnumerable<VolunteerViewModel>>(unmapperVolunteers);

            foreach (var volunteer in mapperVolunteers)
            {
                var translation = VolunteerStatuses.StatusTranslation[volunteer.StatusNumber];
                volunteer.Status = translation[language];
            }
            return mapperVolunteers;
        }

        public async Task<ChatInformationViewModel> GetListVolunteersInChat(
            Guid applicationId, Guid userId, string language)
        {
            ChatInformationViewModel chatInfoViewModel = new ChatInformationViewModel();

            var unmapperApplication = await unitOfWork.ApplicationRepository
                .GetByIdAsync(applicationId);
            chatInfoViewModel.Application = mapper
                .Map<Application, ApplicationViewModel>(unmapperApplication);

            List<Volunteer> unmapperVolunteers = await unitOfWork.VolunteerRepository
                .GetListVolunteersInChat(applicationId);
            chatInfoViewModel.Volunteers = mapper
                .Map<List<Volunteer>, List<VolunteerViewModel>>(unmapperVolunteers);

            foreach (var volunteer in chatInfoViewModel.Volunteers)
            {
                var translation = VolunteerStatuses.StatusTranslation[volunteer.StatusNumber];
                volunteer.Status = translation[language];
            }
            return chatInfoViewModel;
        }

        public async Task<IEnumerable<VolunteerViewModel>> GetListWithChatsByUserId(
            Guid userId, string language)
        {
            IEnumerable<Volunteer> unmapperVolunteers = await unitOfWork.VolunteerRepository
                .GetListWithChatsByUserId(userId);
            var mapperVolunteers = mapper
                .Map<IEnumerable<Volunteer>, IEnumerable<VolunteerViewModel>>(unmapperVolunteers);

            foreach (var volunteer in mapperVolunteers)
            {
                var translation = VolunteerStatuses.StatusTranslation[volunteer.StatusNumber];
                volunteer.Status = translation[language];

                var translationApplicationStatuses =
                    ApplicationStatuses.StatusTranslation[volunteer.Application.StatusNumber];
                volunteer.Application.Status = translationApplicationStatuses[language];
            }
            return mapperVolunteers;
        }

        public async Task<List<ValidationResult>> AcceptVolunteer(Guid userId, Guid volunteerId)
        {
            var validationResults = new List<ValidationResult>();
            var volunteer = await unitOfWork.VolunteerRepository.GetByIdWithoutForeignAsync(volunteerId);
            if (volunteer == null)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerId"));
                return validationResults;
            }
            if (volunteer.Status != (int)VolunteerStatuses.Status.Processing)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerStatus"));
                return validationResults;
            }
            volunteer.Status = (int)VolunteerStatuses.Status.Accepted;
            await unitOfWork.VolunteerRepository.Update(volunteer);

            var application = await unitOfWork.ApplicationRepository.GetByIdAsync(volunteer.ApplicationId);
            if (application == null)
            {
                validationResults.Add(new ValidationResult("incorrectApplicationId"));
                return validationResults;
            }
            if (application.UserId != userId)
            {
                validationResults.Add(new ValidationResult("incorrectOwnerId"));
                return validationResults;
            }
            if (application.NumberOfVolunteers == application.RequiredNumberOfVolunteers)
            {
                validationResults.Add(new ValidationResult("recruitedRequiredNumberVolunteers"));
                return validationResults;
            }

            application.NumberOfVolunteers++;
            await unitOfWork.ApplicationRepository.Update(application);

            Notification notification = new Notification();
            notification.ApplictionId = application.Id;
            notification.UserRecipientId = volunteer.UserId;
            notification.UserSenderId = userId;
            notification.Type = NotificationTypes.Types[(int)NotificationTypes.TypesEnum.AcceptVolunteer];
            notification.CreationDateTime = DateTime.Now;

            await unitOfWork.NotificationRepository.AddAsync(notification);

            return validationResults;
        }

        public async Task<List<ValidationResult>> RejectVolunteer(NotificationCreationModel model, Guid userId)
        {
            var validationResults = new List<ValidationResult>();
            if (model == null || model.UserRecipientId.Equals(null) || model.ApplicationId.Equals(null))
            {
                validationResults.Add(new ValidationResult("incorrectData"));
                return validationResults;
            }

            var volunteer = await unitOfWork.VolunteerRepository
                .GetByUserIdApplicationIdWithoutForeign(
                (Guid)model.UserRecipientId, model.ApplicationId);

            if (volunteer == null)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerId"));
                return validationResults;
            }
            var application =
                await unitOfWork.ApplicationRepository.GetByIdAsync(volunteer.ApplicationId);
            if (application.UserId != userId)
            {
                validationResults.Add(new ValidationResult("incorrectOwnerId"));
                return validationResults;
            }
            if (volunteer.Status != (int)VolunteerStatuses.Status.Processing &&
                volunteer.Status != (int)VolunteerStatuses.Status.Accepted)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerStatus"));
                return validationResults;
            }
            volunteer.Status = (int)VolunteerStatuses.Status.Rejected;
            await unitOfWork.VolunteerRepository.Update(volunteer);

            Notification notification = new Notification();
            notification.ApplictionId = volunteer.ApplicationId;
            notification.UserRecipientId = volunteer.UserId;
            notification.UserSenderId = userId;
            notification.Type = NotificationTypes.Types[(int)NotificationTypes.TypesEnum.RejectVolunteer];
            notification.Reason = model.Reason;
            notification.CreationDateTime = DateTime.Now;

            if (model.Type == NotificationTypes.Types[(int)NotificationTypes.TypesEnum.RemoveVolunteer])
            {
                notification.Type = NotificationTypes.Types[(int)NotificationTypes.TypesEnum.RemoveVolunteer];
                application.NumberOfVolunteers--;
                await unitOfWork.ApplicationRepository.Update(application);
            }

            await unitOfWork.NotificationRepository.AddAsync(notification);

            return validationResults;
        }

        public async Task<List<ValidationResult>> ExitVolunteer(NotificationCreationModel model, Guid userId)
        {
            var validationResults = new List<ValidationResult>();
            if (model == null || model.ApplicationId.Equals(null))
            {
                validationResults.Add(new ValidationResult("incorrectData"));
                return validationResults;
            }

            var volunteer = await unitOfWork.VolunteerRepository
                .GetByUserIdApplicationIdWithoutForeign(userId, model.ApplicationId);

            if (volunteer == null)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerId"));
                return validationResults;
            }
            var application =
                await unitOfWork.ApplicationRepository.GetByIdAsync(volunteer.ApplicationId);
            if (application.UserId == userId)
            {
                validationResults.Add(new ValidationResult("incorrectUserIsOwner"));
                return validationResults;
            }
            if (volunteer.Status != (int)VolunteerStatuses.Status.Accepted)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerStatus"));
                return validationResults;
            }
            volunteer.Status = (int)VolunteerStatuses.Status.Rejected;
            await unitOfWork.VolunteerRepository.Update(volunteer);

            Notification notification = new Notification();
            notification.ApplictionId = volunteer.ApplicationId;
            notification.UserRecipientId = application.UserId;
            notification.UserSenderId = userId;
            notification.Type = NotificationTypes.Types[(int)NotificationTypes.TypesEnum.ExitVolunteer];
            notification.CreationDateTime = DateTime.Now;

            await unitOfWork.NotificationRepository.AddAsync(notification);

            application.NumberOfVolunteers--;
            await unitOfWork.ApplicationRepository.Update(application);

            return validationResults;
        }

        public Task<IEnumerable<VolunteerModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(VolunteerModel model)
        {
            throw new NotImplementedException();
        }

        Task IService<VolunteerModel>.DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }
    }
}
