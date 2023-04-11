using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BLL.Services
{
    public class ApplicationService : IApplicationService
    {
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
            await unitOfWork.ApplicationRepository.AddAsync(mapperApplication);
            return validationResults;
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ApplicationViewModel>> GetAllAsync(string language)
        {
            var unmapperApplications = await unitOfWork.ApplicationRepository.GetAllAsync();
            var mapperApplications = mapper
                .Map<IEnumerable<Application>, IEnumerable<ApplicationViewModel>>(unmapperApplications);
            foreach(var application in mapperApplications)
            {
                var translation = ApplicationStatuses.StatusTranslation[application.StatusNumber];
                application.Status = translation[language];
            }
            return mapperApplications;
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

        public async Task<List<ValidationResult>> ApproveByModerator(Guid applicationId)
        {
            var validationResults = new List<ValidationResult>();
            var application = await unitOfWork.ApplicationRepository.GetByIdAsync(applicationId);
            if (application == null) 
            {
                validationResults.Add(new ValidationResult("Incorect application id"));
                return validationResults;
            }
            if (application.Status != (int) ApplicationStatuses.Status.Processing)
            {
                validationResults.Add(new ValidationResult("Incorect application status"));
                return validationResults;
            }
            application.Status = (int) ApplicationStatuses.Status.InProgress;
            await unitOfWork.ApplicationRepository.Update(application);
            return validationResults;
        }

        public Task UpdateAsync(ApplicationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
