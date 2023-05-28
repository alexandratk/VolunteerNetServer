using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLL.Services
{
    public class ApplicationService : IApplicationService
    {
        private const int StartValueNamberOfVolunteers = 0;
        private const int StartValueOfSum = 0;

        private const int LimitationNumberOfApplicationDocument = 3;
        private const int LimitationApplicationDocumentLength = 5000000;
        private const string LimitationFormatApplicationDocument = "application/pdf";

        private const int LimitationNumberOfApplicationPicture = 10;
        private const int LimitationApplicationPictureLength = 256000;

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
            mapperApplication.DateTimeStart = DateTime.Now;

            if (!ApplicationKinds.Kinds.Contains(model.Kind))
            {
                validationResults.Add(new ValidationResult("invalidKind"));
                return validationResults;
            }

            mapperApplication.NumberOfVolunteers = StartValueNamberOfVolunteers;
            mapperApplication.CurrentSum = StartValueOfSum;

            CityTranslation? cityTranslation = await unitOfWork.CityRepository.GetByNameAsync(model.City);
            if (cityTranslation == null)
            {
                validationResults.Add(new ValidationResult("invalidLocation"));
                return validationResults;
            }
            mapperApplication.CityId = cityTranslation.CityId;
             
            foreach(Guid id in model.SkillIds)
            {
                var skill = await unitOfWork.SkillRepository.GetByIdAsync(id);
                if (skill != null) {
                    var applicationSkill = new ApplicationSkill();
                    applicationSkill.Id = Guid.NewGuid();
                    applicationSkill.SkillId = id;
                    mapperApplication.ApplicationSkills.Add(applicationSkill);
                }
            }

            if (model.ApplicationDocuments.Count > LimitationNumberOfApplicationDocument)
            {
                validationResults.Add(new ValidationResult("numberOfDocumentIsWrong"));
                return validationResults;
            }
            foreach (IFormFile applicationDocument in model.ApplicationDocuments)
            {
                if (applicationDocument == null ||
                    applicationDocument.Length > LimitationApplicationDocumentLength ||
                    applicationDocument.ContentType != LimitationFormatApplicationDocument)
                {
                    validationResults.Add(new ValidationResult("documentIsIncorrect"));
                    return validationResults;
                }
                ApplicationDocument newApplicationDocument = new ApplicationDocument();

                newApplicationDocument.Id = Guid.NewGuid();
                newApplicationDocument.ApplicationId = mapperApplication.Id;
                newApplicationDocument.DocumentFormat = applicationDocument.ContentType;
                newApplicationDocument.Title = applicationDocument.FileName;

                var memoryStream = new MemoryStream();
                applicationDocument.CopyTo(memoryStream);
                newApplicationDocument.Document = memoryStream.ToArray();

                mapperApplication.ApplicationDocuments.Add(newApplicationDocument);
            }

            if (model.ApplicationPictures.Count > LimitationNumberOfApplicationPicture)
            {
                validationResults.Add(new ValidationResult("numberOfPictureIsWrong"));
                return validationResults;
            }
            foreach (IFormFile applicationPicture in model.ApplicationPictures)
            {
                if (applicationPicture == null ||
                    applicationPicture.Length > LimitationApplicationPictureLength)
                {
                    validationResults.Add(new ValidationResult("pictureIsIncorrect"));
                    return validationResults;
                }
                ApplicationPicture newApplicationPicture = new ApplicationPicture();

                newApplicationPicture.Id = Guid.NewGuid();
                newApplicationPicture.ApplicationId = mapperApplication.Id;
                newApplicationPicture.Format = applicationPicture.ContentType;

                var memoryStream = new MemoryStream();
                applicationPicture.CopyTo(memoryStream);
                newApplicationPicture.Data = memoryStream.ToArray();

                mapperApplication.ApplicationPictures.Add(newApplicationPicture);
            }

            await unitOfWork.ApplicationRepository.AddAsync(mapperApplication);
            return validationResults;
        }

        public async Task DeleteAsync(Guid modelId, Guid userId, string userRole)
        {
            var unmapperApplication = await unitOfWork.ApplicationRepository.GetByIdAsync(modelId);
            if (unmapperApplication != null && (unmapperApplication.UserId == userId ||
                userRole == UserRoles.Roles[(int)UserRoles.RolesEnum.Admin] ||
                userRole == UserRoles.Roles[(int)UserRoles.RolesEnum.Moderator]))
            {
                await unitOfWork.VolunteerRepository.DeleteByApplicationId(unmapperApplication.Id);
                await unitOfWork.ApplicationRepository.DeleteAsync(unmapperApplication);
            }
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
                CityTranslation? cityTranslation = await unitOfWork.CityRepository
                    .GetCityTranslationById(application.CityId, language);
                if (cityTranslation != null)
                {
                    application.City = cityTranslation.Name;

                    CountryTranslation? countryTranslation = await unitOfWork.CountryRepository
                        .GetCountryTranslationById(cityTranslation.City.CountryId, language);
                    if (countryTranslation != null)
                    {
                        application.Country = countryTranslation.Name;
                    }
                }

                foreach (SkillModel skillModel in application.ApplicationSkills)
                {
                    SkillTranslation? skillTranslation = await unitOfWork.SkillRepository
                        .GetSkillTranslationById(skillModel.Id, language);
                    if (skillTranslation != null)
                    {
                        skillModel.Title = skillTranslation.Name;
                    }
                }
            }
            return mapperApplications;
        }

        //public async Task<ApplicationViewModel> GetByIdAsync(
        //    Guid applicationId, Guid userId, string userRole, string language)
        //{
        //    var unmapperApplication = await unitOfWork.ApplicationRepository.GetByIdAsync(applicationId);
        //    if (unmapperApplication == null)
        //    {
        //        return null;
        //    }
        //    var mapperApplication = mapper.Map<Application, ApplicationViewModel>(unmapperApplication);

        //    var translation = ApplicationStatuses.StatusTranslation[mapperApplication.StatusNumber];
        //    mapperApplication.Status = translation[language];
        //    CityTranslation? cityTranslation = await unitOfWork.CityRepository
        //            .GetCityTranslationById(mapperApplication.CityId, language);
        //    if (cityTranslation != null)
        //    {
        //        mapperApplication.City = cityTranslation.Name;

        //        CountryTranslation? countryTranslation = await unitOfWork.CountryRepository
        //            .GetCountryTranslationById(cityTranslation.City.CountryId, language);
        //        if (countryTranslation != null)
        //        {
        //            mapperApplication.Country = countryTranslation.Name;
        //        }
        //    }

        //    CategoryTranslation? categoryTranslation = await unitOfWork.CategoryRepository
        //        .GetCategoryTranslationById(mapperApplication.CategoryId, language);
        //    if (categoryTranslation != null)
        //    {
        //        mapperApplication.Category = categoryTranslation.Name;
        //    }


        //    foreach (SkillModel skillModel in mapperApplication.ApplicationSkills)
        //    {
        //        SkillTranslation? skillTranslation = await unitOfWork.SkillRepository
        //            .GetSkillTranslationById(skillModel.Id, language);
        //        if (skillTranslation != null)
        //        {
        //            skillModel.Title = skillTranslation.Name;
        //        }
        //    }

        //    if (unmapperApplication.ApplicationDocuments != null)
        //    {
        //        mapperApplication.ApplicationDocuments = mapper
        //            .Map<List<ApplicationDocument>, List<ApplicationDocumentViewModel>>(
        //            unmapperApplication.ApplicationDocuments);
        //    }

        //    mapperApplication.CheckVolunteer = 
        //        userRole != UserRoles.Roles[(int)UserRoles.RolesEnum.Admin] && 
        //        userRole != UserRoles.Roles[(int)UserRoles.RolesEnum.Moderator];
        //    if (mapperApplication.UserId == userId ||
        //        mapperApplication.RequiredNumberOfVolunteers == mapperApplication.NumberOfVolunteers)
        //    {
        //        mapperApplication.CheckVolunteer = false;
        //    }
        //    if (mapperApplication.CheckVolunteer)
        //    {
        //        var volunteer = await unitOfWork.VolunteerRepository.GetByUserIdApplicationId(userId, applicationId);
        //        mapperApplication.CheckVolunteer = volunteer == null;
        //    }

        //    return mapperApplication;
        //}

        public async Task<IEnumerable<ApplicationViewModel>> GetListForProcessingAsync(string language)
        {
            var unmapperApplications = await unitOfWork.ApplicationRepository.GetListForProcessingAsync();
            var mapperApplications = mapper
                .Map<IEnumerable<Application>, IEnumerable<ApplicationViewModel>>(unmapperApplications);
            foreach (var application in mapperApplications)
            {
                var translation = ApplicationStatuses.StatusTranslation[application.StatusNumber];
                application.Status = translation[language];
                CityTranslation? cityTranslation = await unitOfWork.CityRepository
                    .GetCityTranslationById(application.CityId, language);
                if (cityTranslation != null)
                {
                    application.City = cityTranslation.Name;

                    CountryTranslation? countryTranslation = await unitOfWork.CountryRepository
                        .GetCountryTranslationById(cityTranslation.City.CountryId, language);
                    if (countryTranslation != null)
                    {
                        application.Country = countryTranslation.Name;
                    }
                }
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
                CityTranslation? cityTranslation = await unitOfWork.CityRepository
                    .GetCityTranslationById(application.CityId, language);
                if (cityTranslation != null)
                {
                    application.City = cityTranslation.Name;

                    CountryTranslation? countryTranslation = await unitOfWork.CountryRepository
                        .GetCountryTranslationById(cityTranslation.City.CountryId, language);
                    if (countryTranslation != null)
                    {
                        application.Country = countryTranslation.Name;
                    }
                }

                foreach (SkillModel skillModel in application.ApplicationSkills)
                {
                    SkillTranslation? skillTranslation = await unitOfWork.SkillRepository
                        .GetSkillTranslationById(skillModel.Id, language);
                    if (skillTranslation != null)
                    {
                        skillModel.Title = skillTranslation.Name;
                    }
                }
            }
            return mapperApplications;
        }

        public Task<IEnumerable<ApplicationModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ValidationResult>> ApproveApplication(Guid applicationId, Guid moderatorId)
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

            Volunteer volunteer = new Volunteer();
            volunteer.Id = Guid.NewGuid();
            volunteer.UserId = application.UserId;
            volunteer.ApplicationId = applicationId;
            volunteer.Status = (int)VolunteerStatuses.Status.Owner;
            volunteer.CreationDateTime = DateTime.Now;

            await unitOfWork.VolunteerRepository.AddAsync(volunteer);

            Notification notification = new Notification();
            notification.ApplictionId = application.Id;
            notification.UserRecipientId = application.UserId;
            notification.UserSenderId = moderatorId;
            notification.Type = NotificationTypes.Types[(int)NotificationTypes.TypesEnum.ApproveApplication];
            notification.CreationDateTime = DateTime.Now;

            await unitOfWork.NotificationRepository.AddAsync(notification);

            return validationResults;
        }

        public async Task<List<ValidationResult>> ForbidApplication(NotificationCreationModel model, Guid moderatorId)
        {
            var validationResults = new List<ValidationResult>();
            var application = await unitOfWork.ApplicationRepository.GetByIdAsync(model.ApplicationId);
            if (application == null)
            {
                validationResults.Add(new ValidationResult("incorrectApplicationId"));
                return validationResults;
            }
            application.Status = (int)ApplicationStatuses.Status.Forbidden;
            await unitOfWork.ApplicationRepository.Update(application);

            Notification notification = new Notification();
            notification.ApplictionId = application.Id;
            notification.UserRecipientId = application.UserId;
            notification.UserSenderId = moderatorId;
            notification.Type = NotificationTypes.Types[(int)NotificationTypes.TypesEnum.ForbidApplication];
            notification.Reason = model.Reason;
            notification.CreationDateTime = DateTime.Now;

            await unitOfWork.NotificationRepository.AddAsync(notification);

            return validationResults;
        }

        public Task UpdateAsync(ApplicationModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }
    }
}
