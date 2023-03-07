using AutoMapper;
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
            if (unitOfWork.UserRepository.CheckLogin(model.Login))
            {
                validationResults.Add(new ValidationResult("Invalid login"));
                return validationResults;
            }

            if (!UserRoles.Roles.Contains(model.Role))
            {
                validationResults.Add(new ValidationResult("Invalid role"));
                return validationResults;
            }

            var mapperUser = mapper.Map<UserModel, User>(model);

            mapperUser.Id = Guid.NewGuid();
            mapperUser.Password = HashHelper.ComputeSha256Hash(model.Password);

            CityTranslation? cityTranslation = await unitOfWork.CityRepository.GetByNameAsync(model.City);
            if (cityTranslation == null)
            {
                validationResults.Add(new ValidationResult("Invalid location"));
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
            }
            return mapperUsers;
        }

        public Task<UserViewModel> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
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
                if (unmapperUser.ProfilePicture != null) 
                {
                    mapperUser.ProfilePicture = Convert.ToBase64String(unmapperUser.ProfilePicture.Data);
                }
                if (unmapperUser.UserSkills != null)
                {
                    mapperUser.UserSkills = mapper
                        .Map<List<UserSkill>, List<UserSkillViewModel>>(unmapperUser.UserSkills);
                }
                return mapperUser;
            }
            return null;
        }

        public async Task<List<ValidationResult>> UpdateProfilePictureAsync(
            Guid userId, ProfilePictureCreatingModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (model.ProfilePicture == null)
            {
                validationResults.Add(new ValidationResult("Profile picture is empty"));
                return validationResults;
            }
            if (!LimitationFormatProfilePicture.Contains(model.ProfilePicture.ContentType))
            {
                validationResults.Add(new ValidationResult("Invalid profile picture format"));
                return validationResults;
            }
            if (model.ProfilePicture.Length > LimitationProfilePictureLength)
            {
                validationResults.Add(new ValidationResult("Invalid profile picture length"));
                return validationResults;
            }

            ProfilePicture newProfilePicture = new ProfilePicture();

            newProfilePicture.UserId = userId;
            newProfilePicture.Format = model.ProfilePicture.ContentType;

            Debug.WriteLine("profile picture format == > " + newProfilePicture.Format);

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
                await unitOfWork.ProfilePictureRepository.Update(newProfilePicture);
            }
                
            return validationResults;
        }

        public async Task<List<ValidationResult>> UpdateUserSkillsAsync(
            Guid userId, UserSkillCreatingModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (model.Document == null)
            {
                validationResults.Add(new ValidationResult("Document is empty"));
                return validationResults;
            }
            if (model.Document.Length > LimitationUserSkillDocumentLength)
            {
                validationResults.Add(new ValidationResult("Invalid document lenght"));
                return validationResults;
            }
            if (model.Document.ContentType != LimitationFormatUserSkillDocument)
            {
                validationResults.Add(new ValidationResult("Invalid document format"));
                return validationResults;
            }
            if (model.Document != null)
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
            }
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

        public async Task UpdateAsync(UserModel model)
        {
            var unmapperUser = mapper.Map<UserModel, User>(model);
            await unitOfWork.UserRepository.Update(unmapperUser);
        }

        Task<IEnumerable<UserModel>> IService<UserModel>.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
