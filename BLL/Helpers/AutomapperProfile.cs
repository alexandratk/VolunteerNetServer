using AutoMapper;
using BLL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            CreateMap<UserCreatingModel, User>()
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

            CreateMap<UserSkill, UserSkillProfileModel>().ForMember(a => a.Id, b => b.MapFrom(c => c.Id))
                .ForMember(a => a.SkillId, b => b.MapFrom(c => c.SkillId));



            CreateMap<CountryTranslation, CountryViewModel>().ForMember(a => a.Name, b => b.MapFrom(c => c.Name));
            CreateMap<CityTranslation, CityViewModel>().ForMember(a => a.Name, b => b.MapFrom(c => c.Name));
        }
    }
}
