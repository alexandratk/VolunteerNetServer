﻿using AutoMapper;
using BLL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helpers
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<UserModel, User>().ForMember(um => um.Id, u => u.MapFrom(x => x.Id))
                .ForMember(um => um.Login, u => u.MapFrom(x => x.Login))
                .ForMember(um => um.Password, u => u.MapFrom(x => x.Password))
                .ForMember(um => um.FirstName, u => u.MapFrom(x => x.FirstName))
                .ForMember(um => um.LastName, u => u.MapFrom(x => x.LastName))
                .ForMember(um => um.DateOfBirth, u => u.MapFrom(x => x.DateOfBirth))
                .ForMember(um => um.City, u => u.Ignore())
                .ForMember(um => um.Phone, u => u.MapFrom(x => x.Phone))
                .ForMember(um => um.Role, u => u.MapFrom(x => x.Role));
            CreateMap<User, UserModel>().ForMember(um => um.Id, u => u.MapFrom(x => x.Id))
                .ForMember(um => um.Login, u => u.MapFrom(x => x.Login))
                .ForMember(um => um.Password, u => u.MapFrom(x => x.Password))
                .ForMember(um => um.FirstName, u => u.MapFrom(x => x.FirstName))
                .ForMember(um => um.LastName, u => u.MapFrom(x => x.LastName))
                .ForMember(um => um.DateOfBirth, u => u.MapFrom(x => x.DateOfBirth))
                .ForMember(um => um.Country, u => u.Ignore())
                .ForMember(um => um.City, u => u.Ignore())
                .ForMember(um => um.Phone, u => u.MapFrom(x => x.Phone))
                .ForMember(um => um.Role, u => u.MapFrom(x => x.Role));
            CreateMap<UserCreationModel, User>()
                .ForMember(um => um.Login, u => u.MapFrom(x => x.Login))
                .ForMember(um => um.Password, u => u.MapFrom(x => x.Password))
                .ForMember(um => um.FirstName, u => u.MapFrom(x => x.FirstName))
                .ForMember(um => um.LastName, u => u.MapFrom(x => x.LastName))
                .ForMember(um => um.DateOfBirth, u => u.MapFrom(x => x.DateOfBirth))
                .ForMember(um => um.City, u => u.MapFrom(x => x.City))
                .ForMember(um => um.Phone, u => u.MapFrom(x => x.Phone))
                .ForMember(um => um.City, u => u.Ignore());
            CreateMap<User, UserViewModel>().ForMember(um => um.Id, u => u.MapFrom(x => x.Id))
                .ForMember(um => um.Login, u => u.MapFrom(x => x.Login))
                .ForMember(um => um.Password, u => u.MapFrom(x => x.Password))
                .ForMember(um => um.FirstName, u => u.MapFrom(x => x.FirstName))
                .ForMember(um => um.LastName, u => u.MapFrom(x => x.LastName))
                .ForMember(um => um.DateOfBirth, u => u.MapFrom(x => x.DateOfBirth))
                .ForMember(um => um.Country, u => u.Ignore())
                .ForMember(um => um.City, u => u.MapFrom(x => x.City))
                .ForMember(um => um.Phone, u => u.MapFrom(x => x.Phone))
                .ForMember(um => um.Role, u => u.MapFrom(x => x.Role))
                .ForMember(um => um.ProfilePictureFormat, u => u.MapFrom(x => x.ProfilePicture.Format))
                .ForMember(um => um.ProfilePicture, u => u.Ignore())
                .ForMember(um => um.NumberOfCompletedApplications, u => u.Ignore());


            CreateMap<SkillModel, Skill>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Title, b => b.MapFrom(c => c.Title));
            CreateMap<Skill, SkillModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Title, b => b.MapFrom(c => c.Title));

            CreateMap<Category, CategoryModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Title, b => b.MapFrom(c => c.Title));

            CreateMap<UserSkill, UserSkillViewModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.DocumentId, b => b.MapFrom(c => c.Id));
            CreateMap<UserSkill, UserSkillModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.SkillId, b => b.MapFrom(c => c.SkillId))
                .ForMember(a => a.Skill, b => b.MapFrom(c => c.Skill))
                .ForMember(a => a.UserId, b => b.MapFrom(c => c.UserId))
                .ForMember(a => a.User, b => b.MapFrom(c => c.User))
                .ForMember(a => a.DocumentFormat, b => b.MapFrom(c => c.DocumentFormat))
                .ForMember(a => a.Document, b => b.MapFrom(c => c.Document));


            CreateMap<CountryTranslation, CountryViewModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.CountryId))
                .ForMember(a => a.Name, b => b.MapFrom(c => c.Name));
            CreateMap<CityTranslation, CityViewModel>().ForMember(a => a.Name, b => b.MapFrom(c => c.Name));


            CreateMap<ApplicationCreationModel, Application>().ForMember(a => a.Id, b => b.Ignore())
                .ForMember(a => a.UserId, b => b.Ignore())
                .ForMember(a => a.User, b => b.Ignore())
                .ForMember(a => a.Status, b => b.Ignore())
                .ForMember(a => a.DateTimeEnd, b => b.MapFrom(c => c.DateTimeEnd))
                .ForMember(a => a.DateTimeStart, b => b.Ignore())
                .ForMember(a => a.City, b => b.Ignore())
                .ForMember(a => a.CityId, b => b.Ignore())
                .ForMember(a => a.Title, b => b.MapFrom(c => c.Title))
                .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                .ForMember(a => a.Phone, b => b.MapFrom(c => c.Phone))
                .ForMember(a => a.Email, b => b.MapFrom(c => c.Email))
                .ForMember(a => a.Type, b => b.MapFrom(c => c.Type))
                .ForMember(a => a.Kind, b => b.MapFrom(c => c.Kind))
                .ForMember(a => a.RequiredNumberOfVolunteers, b => b.MapFrom(c => c.RequiredNumberOfVolunteers))
                .ForMember(a => a.RequiredSum, b => b.MapFrom(c => c.RequiredSum))
                .ForMember(a => a.CardNumber, b => b.MapFrom(c => c.CardNumber))
                .ForMember(a => a.AccountNumber, b => b.MapFrom(c => c.AccountNumber))
                .ForMember(a => a.OwnerCardName, b => b.MapFrom(c => c.OwnerCardName))
                .ForMember(a => a.CategoryId, b => b.MapFrom(c => c.CategoryId))
                .ForMember(a => a.NumberOfVolunteers, b => b.Ignore())
                .ForMember(a => a.ApplicationDocuments, b => b.Ignore())
                .ForMember(a => a.ApplicationPictures, b => b.Ignore());
            CreateMap<Application, ApplicationViewModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.UserId, b => b.MapFrom(c => c.UserId))
                .ForMember(a => a.StatusNumber, b => b.MapFrom(c => c.Status))
                .ForMember(a => a.Status, b => b.Ignore())
                .ForMember(a => a.Title, b => b.MapFrom(c => c.Title))
                .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                .ForMember(a => a.DateTimeEnd, b => b.MapFrom(c => c.DateTimeEnd))
                .ForMember(a => a.DateTimeStart, b => b.MapFrom(c => c.DateTimeStart))
                .ForMember(a => a.Phone, b => b.MapFrom(c => c.Phone))
                .ForMember(a => a.Email, b => b.MapFrom(c => c.Email))
                .ForMember(a => a.Type, b => b.MapFrom(c => c.Type))
                .ForMember(a => a.Kind, b => b.MapFrom(c => c.Kind))
                .ForMember(a => a.CityId, b => b.MapFrom(c => c.CityId))
                .ForMember(a => a.CategoryId, b => b.MapFrom(c => c.CategoryId))
                .ForMember(a => a.Category, b => b.Ignore())
                .ForMember(a => a.City, b => b.Ignore())
                .ForMember(a => a.Country, b => b.Ignore())
                .ForMember(a => a.RequiredSum, b => b.MapFrom(c => c.RequiredSum))
                .ForMember(a => a.CurrentSum, b => b.MapFrom(c => c.CurrentSum))
                .ForMember(a => a.RequiredNumberOfVolunteers, b => b.MapFrom(c => c.RequiredNumberOfVolunteers))
                .ForMember(a => a.NumberOfVolunteers, b => b.MapFrom(c => c.NumberOfVolunteers))
                .ForMember(a => a.CheckVolunteer, b => b.Ignore())
                .ForMember(a => a.CheckDelete, b => b.Ignore())
                .ForMember(a => a.ApplicationPictures, b => b.Ignore())
                .ForMember(a => a.ApplicationSkills, b => b.MapFrom(c => c.ApplicationSkills.Select(x => new SkillModel() { Id = x.SkillId }).ToList()));

            CreateMap<ApplicationDocument, ApplicationDocumentViewModel>()
                .ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Title, b => b.MapFrom(c => c.Title));

            CreateMap<ApplicationPicture, ApplicationPictureViewModel>()
                .ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(um => um.Format, u => u.MapFrom(x => x.Format))
                .ForMember(um => um.Picture, u => u.Ignore());

            CreateMap<ApplicationSkill, SkillModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Title, b => b.Ignore());

            CreateMap<MessageCreationModel, Message>().ForMember(a => a.Id, b => b.Ignore())
                .ForMember(a => a.Text, b => b.MapFrom(c => c.Text))
                .ForMember(a => a.DateTime, b => b.Ignore())
                .ForMember(a => a.VolunteerId, b => b.Ignore())
                .ForMember(a => a.Volunteer, b => b.Ignore())
                .ForMember(a => a.VolunteerUserId, b => b.Ignore())
                .ForMember(a => a.VolunteerApplicationId, b => b.Ignore());
            CreateMap<Message, MessageViewModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Volunteer.User.Id))
                .ForMember(a => a.Text, b => b.MapFrom(c => c.Text))
                .ForMember(a => a.DateTime, b => b.MapFrom(c => c.DateTime))
                .ForMember(a => a.FirstName, b => b.MapFrom(c => c.Volunteer.User.FirstName))
                .ForMember(a => a.LastName, b => b.MapFrom(c => c.Volunteer.User.LastName))
                .ForMember(a => a.ProfilePicture, b => b.Ignore())
                .ForMember(a => a.ProfilePictureFormat, b => b.Ignore());

            CreateMap<Notification, NotificationViewModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Type, b => b.MapFrom(c => c.Type))
                .ForMember(a => a.Reason, b => b.MapFrom(c => c.Reason))
                .ForMember(a => a.CreationDateTime, b => b.MapFrom(c => c.CreationDateTime))
                .ForMember(a => a.Application, b => b.MapFrom(c => c.Application))
                .ForMember(a => a.UserSender, b => b.MapFrom(c => c.UserSender))
                .ForMember(a => a.UserRecipient, b => b.MapFrom(c => c.UserRecipient));

            CreateMap<VolunteerCreationModel, Volunteer>().ForMember(a => a.Id, b => b.Ignore())
                .ForMember(a => a.UserId, b => b.Ignore())
                .ForMember(a => a.User, b => b.Ignore())
                .ForMember(a => a.Status, b => b.Ignore())
                .ForMember(a => a.ApplicationId, b => b.MapFrom(c => c.ApplicationId))
                .ForMember(a => a.Application, b => b.Ignore());
            CreateMap<Volunteer, VolunteerViewModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.UserId, b => b.MapFrom(c => c.UserId))
                .ForMember(a => a.User, b => b.MapFrom(c => c.User))
                .ForMember(a => a.ApplicationId, b => b.MapFrom(c => c.ApplicationId))
                .ForMember(a => a.Application, b => b.MapFrom(c => c.Application))
                .ForMember(a => a.StatusNumber, b => b.MapFrom(c => c.Status))
                .ForMember(a => a.CreationDateTime, b => b.MapFrom(c => c.CreationDateTime))
                .ForMember(a => a.Status, b => b.Ignore());

            CreateMap<LiqPayModel, Donate>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Status, b => b.MapFrom(c => c.Status))
                .ForMember(a => a.Amount, b => b.MapFrom(c => c.Amount))
                .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                .ForMember(a => a.Action, b => b.MapFrom(c => c.Action))
                .ForMember(a => a.SenderCardBank, b => b.MapFrom(c => c.SenderCardBank))
                .ForMember(a => a.SenderCardCountry, b => b.MapFrom(c => c.SenderCardCountry))
                .ForMember(a => a.SenderCardMask2, b => b.MapFrom(c => c.SenderCardMask2))
                .ForMember(a => a.SenderCardType, b => b.MapFrom(c => c.SenderCardType))
                .ForMember(a => a.SenderCommission, b => b.MapFrom(c => c.SenderCommission))
                .ForMember(a => a.DateTimeCreation, b => b.Ignore());
            CreateMap<Donate, LiqPayModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Status, b => b.MapFrom(c => c.Status))
                .ForMember(a => a.Data, b => b.Ignore())
                .ForMember(a => a.Signature, b => b.Ignore())
                .ForMember(a => a.Amount, b => b.MapFrom(c => c.Amount))
                .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                .ForMember(a => a.Action, b => b.MapFrom(c => c.Action))
                .ForMember(a => a.SenderCardBank, b => b.MapFrom(c => c.SenderCardBank))
                .ForMember(a => a.SenderCardCountry, b => b.MapFrom(c => c.SenderCardCountry))
                .ForMember(a => a.SenderCardMask2, b => b.MapFrom(c => c.SenderCardMask2))
                .ForMember(a => a.SenderCardType, b => b.MapFrom(c => c.SenderCardType))
                .ForMember(a => a.SenderCommission, b => b.MapFrom(c => c.SenderCommission));
            CreateMap<Donate, LiqPayDonateModel>()
                .ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Sum, b => b.MapFrom(c => c.Amount))
                .ForMember(a => a.DateTimeCreation, b => b.MapFrom(c => c.DateTimeCreation));
        }
    }
}
