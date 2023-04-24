using AutoMapper;
using BLL.Helpers;
using BLL.Interfaces;
using BLL.Services;
using DAL.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure
{
    public class BusinessLogicLayerConfigurator
    {
        public static void ConfigureServices(IServiceCollection serviceCollection)
        {
            DataAccessLayerConfiguratior.ConfigureServices(serviceCollection);
            
            serviceCollection.AddTransient<IApplicationService, ApplicationService>();
            serviceCollection.AddTransient<IAuthService, AuthService>();
            serviceCollection.AddTransient<ILocationService, LocationService>();
            serviceCollection.AddTransient<ISkillService, SkillService>();
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IVolunteerService, VolunteerService>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutomapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            serviceCollection.AddSingleton(mapper);

        }
    }
}
