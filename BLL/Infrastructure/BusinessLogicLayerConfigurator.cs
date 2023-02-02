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
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IAuthService, AuthService>();
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutomapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            serviceCollection.AddSingleton(mapper);

        }
    }
}
