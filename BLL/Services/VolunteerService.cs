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

            await unitOfWork.VolunteerRepository.AddAsync(mapperVolunteer);

            application.NumberOfVolunteers++;
            await unitOfWork.ApplicationRepository.Update(application);

            return validationResults;
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
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

        public async Task<IEnumerable<VolunteerViewModel>> GetListInProcessingByUserId(
            Guid userId, string language)
        {
            IEnumerable<Volunteer> unmapperVolunteers = await unitOfWork.VolunteerRepository
                .GetListInProcessingByUserId(userId);
            var mapperVolunteers = mapper
                .Map<IEnumerable<Volunteer>, IEnumerable<VolunteerViewModel>>(unmapperVolunteers);

            foreach (var volunteer in mapperVolunteers)
            {
                var translation = VolunteerStatuses.StatusTranslation[volunteer.StatusNumber];
                volunteer.Status = translation[language];
            }
            return mapperVolunteers;
        }

        public async Task<List<ValidationResult>> AcceptVolunteer(Guid userId, Guid volunteerId)
        {
            var validationResults = new List<ValidationResult>();
            var volunteer = await unitOfWork.VolunteerRepository.GetByIdAsync(volunteerId);
            if (volunteer == null)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerId"));
                return validationResults;
            }
            if (volunteer.Application.UserId != userId)
            {
                validationResults.Add(new ValidationResult("incorrectOwnerId"));
                return validationResults;
            }
            if (volunteer.Status != (int)VolunteerStatuses.Status.Processing)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerStatus"));
                return validationResults;
            }
            volunteer.Status = (int)VolunteerStatuses.Status.Accepted;
            await unitOfWork.VolunteerRepository.Update(volunteer);
            return validationResults;
        }

        public async Task<List<ValidationResult>> RejectVolunteer(Guid userId, Guid volunteerId)
        {
            var validationResults = new List<ValidationResult>();
            var volunteer = await unitOfWork.VolunteerRepository.GetByIdAsync(volunteerId);
            if (volunteer == null)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerId"));
                return validationResults;
            }
            if (volunteer.Application.UserId != userId)
            {
                validationResults.Add(new ValidationResult("incorrectOwnerId"));
                return validationResults;
            }
            if (volunteer.Status != (int)VolunteerStatuses.Status.Processing)
            {
                validationResults.Add(new ValidationResult("incorrectVolunteerStatus"));
                return validationResults;
            }
            volunteer.Status = (int)VolunteerStatuses.Status.Rejected;
            await unitOfWork.VolunteerRepository.Update(volunteer);
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
    }
}
