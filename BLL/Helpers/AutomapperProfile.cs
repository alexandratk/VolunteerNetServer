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
                .ForMember(um => um.Role, u => u.MapFrom(x => x.Role));
            CreateMap<User, UserModel>().ForMember(um => um.Id, u => u.MapFrom(x => x.Id))
                .ForMember(um => um.Login, u => u.MapFrom(x => x.Login))
                .ForMember(um => um.Password, u => u.MapFrom(x => x.Password))
                .ForMember(um => um.Role, u => u.MapFrom(x => x.Role));
            CreateMap<UserCreatingModel, User>().ForMember(um => um.Id, u => u.MapFrom(x => x.Id))
                .ForMember(um => um.Login, u => u.MapFrom(x => x.Login))
                .ForMember(um => um.Password, u => u.MapFrom(x => x.Password))
                .ForMember(um => um.Role, u => u.MapFrom(x => x.Role))
                .ForMember(um => um.ProfilePicture, u => u.Ignore());
            CreateMap<User, UserViewModel>().ForMember(um => um.Id, u => u.MapFrom(x => x.Id))
                .ForMember(um => um.Login, u => u.MapFrom(x => x.Login))
                .ForMember(um => um.Password, u => u.MapFrom(x => x.Password))
                .ForMember(um => um.Role, u => u.MapFrom(x => x.Role))
                .ForMember(um => um.ProfilePictureFormat, u => u.MapFrom(x => x.ProfilePicture.Format))
                .ForMember(um => um.ProfilePicture, u => u.Ignore());
        }
    }
}
