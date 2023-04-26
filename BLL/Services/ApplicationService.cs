using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLL.Services
{
    public class ApplicationService : IApplicationService
    {
        private const int StartValueNamberOfVolunteers = 0;

        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public ApplicationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ValidationResult>> AddAsync(Guid userId, ApplicationCreationModel model)
        {
            var validationResults = new List<ValidationResult>();
            var mapperApplication = mapper.Map<ApplicationCreationModel, Application>(model);
            mapperApplication.Id = Guid.NewGuid();
            mapperApplication.UserId = userId;
            mapperApplication.Status = (int) ApplicationStatuses.Status.Processing;
            mapperApplication.NumberOfVolunteers = StartValueNamberOfVolunteers;
            await unitOfWork.ApplicationRepository.AddAsync(mapperApplication);
            return validationResults;
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ApplicationViewModel>> GetAllAsync(string userRole, string language)
        {
            List<Application> unmapperApplications = await unitOfWork.ApplicationRepository.GetAllAsync();
            if (userRole == UserRoles.Roles[(int)UserRoles.RolesEnum.User])
            {
                unmapperApplications = unmapperApplications
                    .Where(x => x.Status == (int)ApplicationStatuses.Status.InProgress).ToList();
            }
            var mapperApplications = mapper
                .Map<List<Application>, List<ApplicationViewModel>>(unmapperApplications);
            foreach(var application in mapperApplications)
            {
                var translation = ApplicationStatuses.StatusTranslation[application.StatusNumber];
                application.Status = translation[language];
            }
            return mapperApplications;
        }

        public async Task<ApplicationViewModel> GetByIdAsync(
            Guid applicationId, Guid userId, string userRole, string language)
        {
            var unmapperApplication = await unitOfWork.ApplicationRepository.GetByIdAsync(applicationId);
            if (unmapperApplication == null)
            {
                return null;
            }
            var mapperApplication = mapper.Map<Application, ApplicationViewModel>(unmapperApplication);

            var translation = ApplicationStatuses.StatusTranslation[mapperApplication.StatusNumber];
            mapperApplication.Status = translation[language];

            mapperApplication.CheckVolunteer = 
                userRole != UserRoles.Roles[(int)UserRoles.RolesEnum.Admin] && 
                userRole != UserRoles.Roles[(int)UserRoles.RolesEnum.Moderator];
            if (mapperApplication.UserId == userId ||
                mapperApplication.RequiredNumberOfVolunteers == mapperApplication.NumberOfVolunteers)
            {
                mapperApplication.CheckVolunteer = false;
            }
            if (mapperApplication.CheckVolunteer)
            {
                var volunteer = await unitOfWork.VolunteerRepository.GetByUserIdApplicationId(userId, applicationId);
                mapperApplication.CheckVolunteer = volunteer == null;
            }

            return mapperApplication;
        }

        public async Task<IEnumerable<ApplicationViewModel>> GetListForProcessingAsync(string language)
        {
            var unmapperApplications = await unitOfWork.ApplicationRepository.GetListForProcessingAsync();
            var mapperApplications = mapper
                .Map<IEnumerable<Application>, IEnumerable<ApplicationViewModel>>(unmapperApplications);
            foreach (var application in mapperApplications)
            {
                var translation = ApplicationStatuses.StatusTranslation[application.StatusNumber];
                application.Status = translation[language];
            }
            return mapperApplications;
        }

        public async Task<IEnumerable<ApplicationViewModel>> GetListForUserAsync(Guid userId, string language)
        {
            var unmapperApplications = await unitOfWork.ApplicationRepository.GetListForUserAsync(userId);
            var mapperApplications = mapper
                .Map<IEnumerable<Application>, IEnumerable<ApplicationViewModel>>(unmapperApplications);
            foreach (var application in mapperApplications)
            {
                var translation = ApplicationStatuses.StatusTranslation[application.StatusNumber];
                application.Status = translation[language];
            }
            return mapperApplications;
        }

        public Task<IEnumerable<ApplicationModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ValidationResult>> ApproveApplication(Guid applicationId)
        {
            var validationResults = new List<ValidationResult>();
            var application = await unitOfWork.ApplicationRepository.GetByIdAsync(applicationId);
            if (application == null) 
            {
                validationResults.Add(new ValidationResult("incorrectApplicationId"));
                return validationResults;
            }
            if (application.Status != (int) ApplicationStatuses.Status.Processing)
            {
                validationResults.Add(new ValidationResult("incorrectApplicationStatus"));
                return validationResults;
            }
            application.Status = (int) ApplicationStatuses.Status.InProgress;
            await unitOfWork.ApplicationRepository.Update(application);
            return validationResults;
        }

        public async Task<List<ValidationResult>> ForbidApplication(Guid applicationId)
        {
            var validationResults = new List<ValidationResult>();
            var application = await unitOfWork.ApplicationRepository.GetByIdAsync(applicationId);
            if (application == null)
            {
                validationResults.Add(new ValidationResult("incorrectApplicationId"));
                return validationResults;
            }
            application.Status = (int)ApplicationStatuses.Status.Forbidden;
            await unitOfWork.ApplicationRepository.Update(application);
            return validationResults;
        }

        public Task UpdateAsync(ApplicationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
