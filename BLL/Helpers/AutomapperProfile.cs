using AutoMapper;
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
                .ForMember(um => um.ProfilePicture, u => u.Ignore());


            CreateMap<SkillModel, Skill>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.Title, b => b.MapFrom(c => c.Title));
            CreateMap<Skill, SkillModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
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


            CreateMap<CountryTranslation, CountryViewModel>().ForMember(a => a.Name, b => b.MapFrom(c => c.Name));
            CreateMap<CityTranslation, CityViewModel>().ForMember(a => a.Name, b => b.MapFrom(c => c.Name));


            CreateMap<ApplicationCreationModel, Application>().ForMember(a => a.Id, b => b.Ignore())
                .ForMember(a => a.UserId, b => b.Ignore())
                .ForMember(a => a.User, b => b.Ignore())
                .ForMember(a => a.Status, b => b.Ignore())
                .ForMember(a => a.Title, b => b.MapFrom(c => c.Title))
                .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                .ForMember(a => a.Type, b => b.MapFrom(c => c.Type))
                .ForMember(a => a.RequiredNumberOfVolunteers, b => b.MapFrom(c => c.RequiredNumberOfVolunteers))
                .ForMember(a => a.NumberOfVolunteers, b => b.Ignore());
            CreateMap<Application, ApplicationViewModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.UserId, b => b.MapFrom(c => c.UserId))
                .ForMember(a => a.StatusNumber, b => b.MapFrom(c => c.Status))
                .ForMember(a => a.Status, b => b.Ignore())
                .ForMember(a => a.Title, b => b.MapFrom(c => c.Title))
                .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                .ForMember(a => a.Type, b => b.MapFrom(c => c.Type))
                .ForMember(a => a.RequiredNumberOfVolunteers, b => b.MapFrom(c => c.RequiredNumberOfVolunteers))
                .ForMember(a => a.NumberOfVolunteers, b => b.MapFrom(c => c.NumberOfVolunteers))
                .ForMember(a => a.CheckVolunteer, b => b.Ignore());


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
                .ForMember(a => a.Status, b => b.Ignore());

            CreateMap<MessageCreationModel, Message>().ForMember(a => a.Id, b => b.Ignore())
                .ForMember(a => a.Text, b => b.MapFrom(c => c.Text))
                .ForMember(a => a.DateTime, b => b.Ignore())
                .ForMember(a => a.VolunteerId, b => b.Ignore())
                .ForMember(a => a.Volunteer, b => b.Ignore())
                .ForMember(a => a.VolunteerUserId, b => b.Ignore())
                .ForMember(a => a.VolunteerApplicationId, b => b.Ignore());
            CreateMap<Message, MessageViewModel>().ForMember(a => a.Id, b => b.Ignore())
                .ForMember(a => a.Text, b => b.MapFrom(c => c.Text))
                .ForMember(a => a.DateTime, b => b.MapFrom(c => c.DateTime))
                .ForMember(a => a.FirstName, b => b.MapFrom(c => c.Volunteer.User.FirstName))
                .ForMember(a => a.LastName, b => b.MapFrom(c => c.Volunteer.User.LastName));
        }
    }
}
