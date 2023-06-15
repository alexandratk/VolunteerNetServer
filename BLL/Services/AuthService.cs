using AutoMapper;
using BLL.Helpers;
using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using DAL.DefaultData;

namespace BLL.Services
{
    public class AuthService : IAuthService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        private const string RoleUser = "user";

        public AuthService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ValidationResult>> RegisterUserAsync(UserCreationModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (unitOfWork.UserRepository.CheckLogin(model.Login))
            {
                validationResults.Add(new ValidationResult("invalidLogin"));
                return validationResults;
            }
            
            var mapperUser = mapper.Map<UserCreationModel, User>(model);

            mapperUser.Id = Guid.NewGuid();
            mapperUser.Password = HashHelper.ComputeSha256Hash(model.Password);
            mapperUser.Role = RoleUser;

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

        public async Task<AuthResponseModel> AuthUser(AuthRequestModel authRequestModel)
        {
            var unmapperUser = await unitOfWork.UserRepository.GetByLoginAndPass(
                authRequestModel.Login, HashHelper.ComputeSha256Hash(authRequestModel.Password));
            if (unmapperUser == null)
            {
                return new AuthResponseModel();
            }
            var mapperUser = mapper.Map<User, UserModel>(unmapperUser);

            var user = unitOfWork.UserRepository.GetByLoginAndPass(authRequestModel.Login, HashHelper.ComputeSha256Hash(authRequestModel.Password));
            //if (user == null)
            //    throw new Exception("User not found");
            //Console.WriteLine("2222");
            var token = generateJWTToken(mapperUser);
            return new AuthResponseModel()
            {
                Role = mapperUser.Role,
                jwtToken = token
            };
        }

        string generateJWTToken(UserModel person)
        {

            var now = DateTime.UtcNow;

            var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.Id.ToString()),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role)
                };
            ClaimsIdentity claimsIdentity =
            new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);

            var jwt = new JwtSecurityToken(
                 issuer: AuthOptions.ISSUER,
                 audience: AuthOptions.AUDIENCE,
                 notBefore: now,
                 claims: claimsIdentity.Claims,
                 expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                 signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return encodedJwt;
        }

        public async Task<List<ApplicationViewModel>> GetAllApplicationsAsync(string language)
        {
            List<Application> unmapperApplications = await unitOfWork.ApplicationRepository.GetAllAsync();
            unmapperApplications = unmapperApplications
                    .Where(x => x.Status == (int)ApplicationStatuses.Status.InProgress).ToList();

            var mapperApplications = mapper
                .Map<List<Application>, List<ApplicationViewModel>>(unmapperApplications);
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

        public async Task<ApplicationViewModel> GetApplicationById(Guid applicationId, string language)
        {
            var unmapperApplication = await unitOfWork.ApplicationRepository.GetByIdAsync(applicationId);
            if (unmapperApplication == null)
            {
                return null;
            }
            var mapperApplication = mapper.Map<Application, ApplicationViewModel>(unmapperApplication);

            var translation = ApplicationStatuses.StatusTranslation[mapperApplication.StatusNumber];
            mapperApplication.Status = translation[language];
            CityTranslation? cityTranslation = await unitOfWork.CityRepository
                    .GetCityTranslationById(mapperApplication.CityId, language);
            if (cityTranslation != null)
            {
                mapperApplication.City = cityTranslation.Name;

                CountryTranslation? countryTranslation = await unitOfWork.CountryRepository
                    .GetCountryTranslationById(cityTranslation.City.CountryId, language);
                if (countryTranslation != null)
                {
                    mapperApplication.Country = countryTranslation.Name;
                }
            }

            CategoryTranslation? categoryTranslation = await unitOfWork.CategoryRepository
                .GetCategoryTranslationById(mapperApplication.CategoryId, language);
            if (categoryTranslation != null)
            {
                mapperApplication.Category = categoryTranslation.Name;
            }


            foreach (SkillModel skillModel in mapperApplication.ApplicationSkills)
            {
                SkillTranslation? skillTranslation = await unitOfWork.SkillRepository
                    .GetSkillTranslationById(skillModel.Id, language);
                if (skillTranslation != null)
                {
                    skillModel.Title = skillTranslation.Name;
                }
            }

            if (unmapperApplication.ApplicationDocuments != null)
            {
                mapperApplication.ApplicationDocuments = mapper
                    .Map<List<ApplicationDocument>, List<ApplicationDocumentViewModel>>(
                    unmapperApplication.ApplicationDocuments);
            }

            foreach (ApplicationPicture applicationPicture in unmapperApplication.ApplicationPictures)
            {
                ApplicationPictureViewModel applicationPictureViewModel = new ApplicationPictureViewModel();
                applicationPictureViewModel.Id = applicationPicture.Id;
                applicationPictureViewModel.Format = applicationPicture.Format;
                applicationPictureViewModel.Picture = Convert.ToBase64String(applicationPicture.Data);

                mapperApplication.ApplicationPictures.Add(applicationPictureViewModel);
            }

            mapperApplication.CheckDonate =
               mapperApplication.RequiredSum - mapperApplication.CurrentSum > 0 &&
               (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed] ||
               mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Monetary]);


            return mapperApplication;
        }

        public async Task<ApplicationViewModel> GetApplicationByIdAuth(
            Guid applicationId, Guid userId, string userRole, string language)
        {
            ApplicationViewModel mapperApplication = await GetApplicationById(applicationId, language);

            mapperApplication.CheckVolunteer =
                userRole != UserRoles.Roles[(int)UserRoles.RolesEnum.Admin] &&
                userRole != UserRoles.Roles[(int)UserRoles.RolesEnum.Moderator];
            if (mapperApplication.UserId == userId ||
                mapperApplication.RequiredNumberOfVolunteers == mapperApplication.NumberOfVolunteers)
            {
                mapperApplication.CheckVolunteer = false;
            }
            var volunteer = await unitOfWork.VolunteerRepository
                .GetByUserIdApplicationId(userId, applicationId);
            if (mapperApplication.CheckVolunteer)
            {
                mapperApplication.CheckVolunteer = volunteer == null;
            }
            if (mapperApplication != null && (mapperApplication.UserId == userId ||
                userRole == UserRoles.Roles[(int)UserRoles.RolesEnum.Admin]))
            {
                mapperApplication.CheckDelete = true;
            }
            if (mapperApplication.UserId == userId)
            {
                mapperApplication.CheckComplete = true;
            }
            if (volunteer != null && 
                volunteer.Status == (int)VolunteerStatuses.Status.Accepted &&
                (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Volunteer] ||
                mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed]))
            {
                mapperApplication.CheckExit = true;
            }
            if (volunteer != null &&
                (volunteer.Status == (int)VolunteerStatuses.Status.Accepted ||
                volunteer.Status == (int)VolunteerStatuses.Status.Owner) &&
                (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Volunteer] ||
                mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed])
                )
            {
                mapperApplication.CheckChat = true;
            }

            if (volunteer != null &&
                volunteer.Status == (int)VolunteerStatuses.Status.Rejected)
            {
                mapperApplication.CheckVolunteerIsReject = true;
            }
            if (volunteer != null &&
                volunteer.Status == (int)VolunteerStatuses.Status.Processing)
            {
                mapperApplication.CheckVolunteerWait = true;
            }

            if (language == Languages.LanguagesList[(int)Languages.LanguagesEnum.uk])
            {
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsUk[(int)ApplicationKinds.KindsEnum.Mixed];
                }
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Monetary])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsUk[(int)ApplicationKinds.KindsEnum.Monetary];
                }
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Volunteer])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsUk[(int)ApplicationKinds.KindsEnum.Volunteer];
                }
            }
            if (language == Languages.LanguagesList[(int)Languages.LanguagesEnum.pl])
            {
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsPl[(int)ApplicationKinds.KindsEnum.Mixed];
                }
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Monetary])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsPl[(int)ApplicationKinds.KindsEnum.Monetary];
                }
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Volunteer])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsPl[(int)ApplicationKinds.KindsEnum.Volunteer];
                }
            }
            return mapperApplication;
        }

        public async Task<ApplicationViewModel> GetApplicationByIdUnauth(
            Guid applicationId, string language)
        {
            ApplicationViewModel mapperApplication = await GetApplicationById(applicationId, language);

            mapperApplication.CheckVolunteer = false;
            mapperApplication.CheckDelete = false;
            mapperApplication.CheckComplete = false;
            mapperApplication.CheckChat = false;
            mapperApplication.CheckExit = false;
            mapperApplication.CheckVolunteerIsReject = false;
            mapperApplication.CheckVolunteerWait = false;

            if (language == Languages.LanguagesList[(int)Languages.LanguagesEnum.uk])
            {
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsUk[(int)ApplicationKinds.KindsEnum.Mixed];
                }
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Monetary])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsUk[(int)ApplicationKinds.KindsEnum.Monetary];
                }
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Volunteer])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsUk[(int)ApplicationKinds.KindsEnum.Volunteer];
                }
            }
            if (language == Languages.LanguagesList[(int)Languages.LanguagesEnum.pl])
            {
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsPl[(int)ApplicationKinds.KindsEnum.Mixed];
                }
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Monetary])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsPl[(int)ApplicationKinds.KindsEnum.Monetary];
                }
                if (mapperApplication.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Volunteer])
                {
                    mapperApplication.Kind = ApplicationKinds.KindsPl[(int)ApplicationKinds.KindsEnum.Volunteer];
                }
            }
            return mapperApplication;
        }

        public DocumentModel GetApplicationDocument(Guid id)
        {
            ApplicationDocument unmapperDocument = unitOfWork.ApplicationRepository.GetDocumentById(id);
            DocumentModel documentModel = new DocumentModel();
            if (unmapperDocument != null)
            {
                documentModel.DocumentFormat = unmapperDocument.DocumentFormat;
                documentModel.Document = unmapperDocument.Document;
                documentModel.Title = unmapperDocument.Title;
            }
            return documentModel;
        }
    }
}
