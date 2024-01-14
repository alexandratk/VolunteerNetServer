﻿using AutoMapper;
using BLL.Helpers;
using BLL.Interfaces;
using BLL.Models;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        private const int LimitationProfilePictureLength = 256000;

        private const int LimitationUserSkillDocumentLength = 5000000;

        private const string LimitationFormatUserSkillDocument = "application/pdf";

        private List<string> LimitationFormatProfilePicture = new List<string>()
        {
            "image/jpeg",
            "image/jpg",
            "image/png",
        };

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ValidationResult>> AddUserAsync(UserModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (!(await unitOfWork.UserRepository.CheckLogin(model.Login)))
            {
                validationResults.Add(new ValidationResult("invalidLogin"));
                return validationResults;
            }

            if (!UserRoles.Roles.Contains(model.Role))
            {
                validationResults.Add(new ValidationResult("invalidRole"));
                return validationResults;
            }

            var mapperUser = mapper.Map<UserModel, User>(model);

            mapperUser.Id = Guid.NewGuid();
            mapperUser.Password = HashHelper.ComputeSha256Hash(model.Password);

            CityTranslation? cityTranslation = await unitOfWork.CityRepository.GetByNameAsync(model.City);
            if (cityTranslation == null)
            {
                validationResults.Add(new ValidationResult("invalidLocation"));
                return validationResults;
            }
            mapperUser.CityId = cityTranslation.CityId;

            await unitOfWork.UserRepository.AddAsync(mapperUser);
            return validationResults;
        }

        public async Task DeleteAsync(Guid modelId)
        {
            var unmapperUser = await unitOfWork.UserRepository.GetByIdAsync(modelId);
            if (unmapperUser != null)
            {
                await unitOfWork.UserRepository.DeleteAsync(unmapperUser);
            }
        }

        public async Task DeleteNotificationAsync(Guid notificationId, Guid userId)
        {
            var unmapperNotification = await unitOfWork.NotificationRepository.GetByIdAsync(notificationId);
            if (unmapperNotification != null && unmapperNotification.UserRecipientId == userId)
            {
                await unitOfWork.NotificationRepository.DeleteAsync(unmapperNotification);
            }
        }

        public async Task<IEnumerable<UserViewModel>> GetAllAsync(string language)
        {
            var unmapperUsers = await unitOfWork.UserRepository.GetAllAsync();
            var mapperUsers = mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(unmapperUsers);
            foreach(var mapperUser in mapperUsers)
            {
                var unmapperUser = unmapperUsers.Where(r => r.Id == mapperUser.Id).FirstOrDefault();
                CityTranslation? cityTranslation = await unitOfWork.CityRepository
                    .GetCityTranslationById(unmapperUser.CityId, language);
                if (cityTranslation != null)
                {
                    mapperUser.City = cityTranslation.Name;

                    CountryTranslation? countryTranslation = await unitOfWork.CountryRepository
                        .GetCountryTranslationById(cityTranslation.City.CountryId, language);
                    if (countryTranslation != null)
                    {
                        mapperUser.Country = countryTranslation.Name;
                    }
                }
                if (unmapperUser.ProfilePicture != null)
                {
                    mapperUser.ProfilePicture = Convert.ToBase64String(unmapperUser.ProfilePicture.Data);
                }
                if (language == Languages.LanguagesList[(int)Languages.LanguagesEnum.uk])
                {
                    if (mapperUser.Role == UserRoles.Roles[(int)UserRoles.RolesEnum.User])
                    {
                        mapperUser.Role = UserRoles.RolesUk[(int)UserRoles.RolesEnum.User];
                    }
                    if (mapperUser.Role == UserRoles.Roles[(int)UserRoles.RolesEnum.Admin])
                    {
                        mapperUser.Role = UserRoles.RolesUk[(int)UserRoles.RolesEnum.Admin];
                    }
                    if (mapperUser.Role == UserRoles.Roles[(int)UserRoles.RolesEnum.Moderator])
                    {
                        mapperUser.Role = UserRoles.RolesUk[(int)UserRoles.RolesEnum.Moderator];
                    }
                }
                if (language == Languages.LanguagesList[(int)Languages.LanguagesEnum.pl])
                {
                    if (mapperUser.Role == UserRoles.Roles[(int)UserRoles.RolesEnum.User])
                    {
                        mapperUser.Role = UserRoles.RolesPl[(int)UserRoles.RolesEnum.User];
                    }
                    if (mapperUser.Role == UserRoles.Roles[(int)UserRoles.RolesEnum.Admin])
                    {
                        mapperUser.Role = UserRoles.RolesPl[(int)UserRoles.RolesEnum.Admin];
                    }
                    if (mapperUser.Role == UserRoles.Roles[(int)UserRoles.RolesEnum.Moderator])
                    {
                        mapperUser.Role = UserRoles.RolesPl[(int)UserRoles.RolesEnum.Moderator];
                    }
                }
            }
            return mapperUsers;
        }

        public async Task<UserViewModel> GetByIdAsync(Guid id)
        {
            var unmapperUser = await unitOfWork.UserRepository.GetByIdAsync(id);
            if (unmapperUser != null)
            {
                var mapperUser = mapper.Map<User, UserViewModel>(unmapperUser);
                mapperUser.NumberOfCompletedApplications = 0;
                return mapperUser;
            }
            return null;
        }

        public async Task<UserViewModel> GetByIdAsync(Guid id, string language)
        {
            var unmapperUser = await unitOfWork.UserRepository.GetByIdAsync(id);
            if (unmapperUser != null)
            {
                var mapperUser = mapper.Map<User, UserViewModel>(unmapperUser);
                CityTranslation? cityTranslation = await unitOfWork.CityRepository
                    .GetCityTranslationById(unmapperUser.CityId, language);
                if (cityTranslation != null)
                {
                    mapperUser.City = cityTranslation.Name;

                    CountryTranslation? countryTranslation = await unitOfWork.CountryRepository
                        .GetCountryTranslationById(cityTranslation.City.CountryId, language);
                    if (countryTranslation != null)
                    {
                        mapperUser.Country = countryTranslation.Name;
                    }
                }
                mapperUser.NumberOfCompletedApplications = unmapperUser.Volunteers
                    .Where(x => x.Status == (int)VolunteerStatuses.Status.Completed).Count();
                mapperUser.NumberOfOwnerCompletedApplications = unmapperUser.Volunteers
                    .Where(x => x.Status == (int)VolunteerStatuses.Status.Owner).Count();

                if (unmapperUser.ProfilePicture != null) 
                {
                    mapperUser.ProfilePicture = Convert.ToBase64String(unmapperUser.ProfilePicture.Data);
                }
                if (unmapperUser.UserSkills != null)
                {
                    mapperUser.UserSkills = mapper
                        .Map<List<UserSkill>, List<UserSkillViewModel>>(unmapperUser.UserSkills);
                    foreach(UserSkillViewModel userSkillView in mapperUser.UserSkills)
                    {
                        SkillTranslation? skillTranslation = await unitOfWork.SkillRepository
                            .GetSkillTranslationById(userSkillView.Skill.Id, language);
                        if (skillTranslation != null) {
                            userSkillView.Skill.Title = skillTranslation.Name;
                        }
                    }
                }
                return mapperUser;
            }
            return null;
        }

        public async Task<List<ValidationResult>> UpdateProfilePictureAsync(
            Guid userId, ProfilePictureCreationModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (model.ProfilePicture == null)
            {
                validationResults.Add(new ValidationResult("profilePictureIsEmpty"));
                return validationResults;
            }
            if (!LimitationFormatProfilePicture.Contains(model.ProfilePicture.ContentType))
            {
                validationResults.Add(new ValidationResult("invalidProfilePictureFormat"));
                return validationResults;
            }
            if (model.ProfilePicture.Length > LimitationProfilePictureLength)
            {
                validationResults.Add(new ValidationResult("invalidProfilePictureLength"));
                return validationResults;
            }

            ProfilePicture newProfilePicture = new ProfilePicture();

            newProfilePicture.UserId = userId;
            newProfilePicture.Format = model.ProfilePicture.ContentType;

            var memoryStream = new MemoryStream();
            model.ProfilePicture.CopyTo(memoryStream);
            newProfilePicture.Data = memoryStream.ToArray();
                
            var currentProfilePicture = await unitOfWork.ProfilePictureRepository
                .GetByUserIdAsync(userId);
            if (currentProfilePicture == null)
            {
                newProfilePicture.Id = Guid.NewGuid();
                await unitOfWork.ProfilePictureRepository.AddAsync(newProfilePicture);
            } else
            {
                newProfilePicture.Id = currentProfilePicture.Id;
                await unitOfWork.ProfilePictureRepository.UpdateAsync(newProfilePicture);
            }
                
            return validationResults;
        }

        public async Task<List<ValidationResult>> DeleteProfilePictureAsync(Guid userId)
        {
            var validationResults = new List<ValidationResult>();

            var profilePicture = await unitOfWork.ProfilePictureRepository.GetByUserIdAsync(userId);

            if (profilePicture != null)
            {
                await unitOfWork.ProfilePictureRepository.DeleteAsync(profilePicture);
            }

            return validationResults;
        }

        public async Task<List<ValidationResult>> UpdateUserSkillsAsync(
            Guid userId, UserSkillCreationModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (model.Document == null)
            {
                validationResults.Add(new ValidationResult("documentIsEmpty"));
                return validationResults;
            }
            if (model.Document.Length > LimitationUserSkillDocumentLength)
            {
                validationResults.Add(new ValidationResult("invalidDocumentLength"));
                return validationResults;
            }
            if (model.Document.ContentType != LimitationFormatUserSkillDocument)
            {
                validationResults.Add(new ValidationResult("invalidDocumentFormat"));
                return validationResults;
            }
            var userSkill = await unitOfWork.UserSkillRepository.GetByUserIdSkillIdAsync(userId, model.SkillId);
            if (userSkill == null)
            {
                UserSkill newUserSkill = new UserSkill();

                newUserSkill.Id = Guid.NewGuid();
                newUserSkill.UserId = userId;
                newUserSkill.SkillId = model.SkillId;
                newUserSkill.DocumentFormat = model.Document.ContentType;

                var memoryStream = new MemoryStream();
                model.Document.CopyTo(memoryStream);
                newUserSkill.Document = memoryStream.ToArray();

                await unitOfWork.UserSkillRepository.AddAsync(newUserSkill);
            } else
            {
                userSkill.DocumentFormat = model.Document.ContentType;

                var memoryStream = new MemoryStream();
                model.Document.CopyTo(memoryStream);
                userSkill.Document = memoryStream.ToArray();

                await unitOfWork.UserSkillRepository.UpdateAsync(userSkill);
            }

            return validationResults;
        }

        public async Task<List<ValidationResult>> DeleteUserSkillsAsync(Guid userId, Guid skillId)
        {
            var validationResults = new List<ValidationResult>();
            if (skillId == null)
            {
                validationResults.Add(new ValidationResult("skillIdIsEmpty"));
                return validationResults;
            }

            var userSkill = await unitOfWork.UserSkillRepository.GetByUserIdSkillIdAsync(userId, skillId);

            if (userSkill == null)
            {
                validationResults.Add(new ValidationResult("skillIdOrUserIdIsWrong"));
                return validationResults;
            }

            await unitOfWork.UserSkillRepository.DeleteAsync(userSkill);
            return validationResults;
        }

        public DocumentModel GetUserSkillDocument(Guid id)
        {
            UserSkill unmapperDocument = unitOfWork.UserSkillRepository.GetById(id);
            DocumentModel documentModel = new DocumentModel();
            if (unmapperDocument != null)
            {
                documentModel.DocumentFormat = unmapperDocument.DocumentFormat;
                documentModel.Document = unmapperDocument.Document;
            }
            return documentModel;
        }

        public async Task<IEnumerable<NotificationViewModel>> GetListNotifications(Guid userId)
        {
            var unmapperNotifications = await unitOfWork.NotificationRepository.GetListByUserRecipientId(userId);
            var mapperNotifications = mapper
                .Map<IEnumerable<Notification>, IEnumerable<NotificationViewModel>>(unmapperNotifications);

            return mapperNotifications;
        }

        public async Task<int> GetNumberOfNotificationsById(Guid userId)
        {
            var unmapperNotifications = await unitOfWork.NotificationRepository.GetListByUserRecipientId(userId);
            var numberOfNotification = unmapperNotifications.Count();

            IEnumerable<Volunteer> unmapperVolunteers = await unitOfWork.VolunteerRepository
                .GetListInProcessingByOwnerId(userId);

            numberOfNotification += unmapperVolunteers.Count();

            return numberOfNotification;
        }

        public async Task<List<ValidationResult>> UpdateInfoAsync(UserCreationModel model, Guid userId)
        {
            var validationResults = new List<ValidationResult>();
            var user = await unitOfWork.UserRepository.GetByIdAsync(userId);
            if (user == null)
            {
                validationResults.Add(new ValidationResult("invalidUserId"));
                return validationResults;
            }
            user.Phone = model.Phone;
            user.DateOfBirth = model.DateOfBirth;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;

            CityTranslation? cityTranslation = await unitOfWork.CityRepository.GetByNameAsync(model.City);
            if (cityTranslation == null)
            {
                validationResults.Add(new ValidationResult("invalidLocation"));
                return validationResults;
            }
            user.CityId = cityTranslation.CityId;

            await unitOfWork.UserRepository.UpdateAsync(user);
            return validationResults;
        }

        Task<IEnumerable<UserModel>> IService<UserModel>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
