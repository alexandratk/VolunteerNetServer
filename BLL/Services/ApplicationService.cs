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
                var volunteers = await unitOfWork.VolunteerRepository
                    .GetListVolunteersInChatWithoutForeign(modelId);
                for (int i = 0; i < volunteers.Count; i++)
                {
                    Notification notification = new Notification();
                    notification.UserRecipientId = volunteers[i].UserId;
                    notification.UserSenderId = userId;
                    notification.Type = NotificationTypes.Types[(int)NotificationTypes.TypesEnum.DeleteApplication];
                    notification.CreationDateTime = DateTime.Now;
                    await unitOfWork.NotificationRepository.AddAsync(notification);
                }
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

                if (language == Languages.LanguagesList[(int)Languages.LanguagesEnum.uk])
                {
                    if (application.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed])
                    {
                        application.Kind = ApplicationKinds.KindsUk[(int)ApplicationKinds.KindsEnum.Mixed];
                    }
                    if (application.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Monetary])
                    {
                        application.Kind = ApplicationKinds.KindsUk[(int)ApplicationKinds.KindsEnum.Monetary];
                    }
                    if (application.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Volunteer])
                    {
                        application.Kind = ApplicationKinds.KindsUk[(int)ApplicationKinds.KindsEnum.Volunteer];
                    }
                }
                if (language == Languages.LanguagesList[(int)Languages.LanguagesEnum.pl])
                {
                    if (application.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed])
                    {
                        application.Kind = ApplicationKinds.KindsPl[(int)ApplicationKinds.KindsEnum.Mixed];
                    }
                    if (application.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Monetary])
                    {
                        application.Kind = ApplicationKinds.KindsPl[(int)ApplicationKinds.KindsEnum.Monetary];
                    }
                    if (application.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Volunteer])
                    {
                        application.Kind = ApplicationKinds.KindsPl[(int)ApplicationKinds.KindsEnum.Volunteer];
                    }
                }
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

        public async Task<IEnumerable<ApplicationViewModel>> GetListForUserAsync(
            Guid userId, string language)
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

        public async Task<List<ValidationResult>> ApproveApplication(
            Guid applicationId, Guid moderatorId)
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
            await unitOfWork.ApplicationRepository.UpdateAsync(application);

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

        public async Task<List<ValidationResult>> ForbidApplication(
            NotificationCreationModel model, Guid moderatorId)
        {
            var validationResults = new List<ValidationResult>();
            var application = await unitOfWork.ApplicationRepository.GetByIdAsync(model.ApplicationId);
            if (application == null)
            {
                validationResults.Add(new ValidationResult("incorrectApplicationId"));
                return validationResults;
            }
            application.Status = (int)ApplicationStatuses.Status.Forbidden;
            await unitOfWork.ApplicationRepository.UpdateAsync(application);

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

        public async Task<List<ValidationResult>> CompleteApplication(
            Guid applicationId, Guid userId)
        {
            var validationResults = new List<ValidationResult>();
            var application = await unitOfWork.ApplicationRepository.GetByIdAsync(applicationId);
            if (application == null)
            {
                validationResults.Add(new ValidationResult("incorrectApplicationId"));
                return validationResults;
            }
            if (application.Status != (int)ApplicationStatuses.Status.InProgress)
            {
                validationResults.Add(new ValidationResult("incorrectApplicationStatus"));
                return validationResults;
            }
            application.Status = (int)ApplicationStatuses.Status.Сompleted;
            await unitOfWork.ApplicationRepository.UpdateAsync(application);

            var volunteers = await unitOfWork.VolunteerRepository
                .GetListVolunteersInChatWithoutForeign(applicationId);
            for (int i = 0; i < volunteers.Count; i++)
            {
                if (volunteers[i].Status == (int)VolunteerStatuses.Status.Accepted)
                {
                    volunteers[i].Status = (int)VolunteerStatuses.Status.Completed;
                    await unitOfWork.VolunteerRepository.UpdateAsync(volunteers[i]);

                    Notification notification = new Notification();
                    notification.ApplictionId = application.Id;
                    notification.UserRecipientId = volunteers[i].UserId;
                    notification.UserSenderId = userId;
                    notification.Type = NotificationTypes.Types[(int)NotificationTypes.TypesEnum.CompleteApplication];
                    notification.CreationDateTime = DateTime.Now;
                    await unitOfWork.NotificationRepository.AddAsync(notification);
                }
            }

            return validationResults;
        }

        public async Task CompleteApplicationBackgroundService()
        {

            var applications = await unitOfWork.ApplicationRepository.GetListWithCurrentData();
            for (int i = 0; i < applications.Count; i++)
            {
                applications[i].Status = (int)ApplicationStatuses.Status.Сompleted;
                await unitOfWork.ApplicationRepository.UpdateAsync(applications[i]);

                var volunteers = await unitOfWork.VolunteerRepository
                    .GetListVolunteersInChatWithoutForeign(applications[i].Id);
                for (int j = 0; j < volunteers.Count; j++)
                {
                    if (volunteers[j].Status == (int)VolunteerStatuses.Status.Accepted)
                    {
                        volunteers[j].Status = (int)VolunteerStatuses.Status.Completed;
                        await unitOfWork.VolunteerRepository.UpdateAsync(volunteers[j]);

                        Notification notification = new Notification();
                        notification.ApplictionId = applications[i].Id;
                        notification.UserRecipientId = volunteers[j].UserId;
                        notification.UserSenderId = applications[i].UserId;
                        notification.Type = NotificationTypes.Types[(int)NotificationTypes.TypesEnum.CompleteApplication];
                        notification.CreationDateTime = DateTime.Now;
                        await unitOfWork.NotificationRepository.AddAsync(notification);
                    }
                }
            }
        }

        public Task UpdateAsync(ApplicationModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid modelId)
        {
            throw new NotImplementedException();
        }

        public int test()
        {
            return 3;
        }
    }
}
