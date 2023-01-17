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
            CreateMap<User, UserModel>().ForMember(um => um.Id, u => u.MapFrom(x => x.Id))
                .ForMember(um => um.Login, u => u.MapFrom(x => x.Login))
                .ForMember(um => um.Password, u => u.MapFrom(x => x.Password))
                .ReverseMap();
           
        }
    }
}
