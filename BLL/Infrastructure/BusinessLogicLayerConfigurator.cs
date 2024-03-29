﻿using AutoMapper;
using BLL.BackgroundServices;
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

            serviceCollection.AddHostedService<ApplicationBackgroundService>();

            serviceCollection.AddScoped<IApplicationService, ApplicationService>();
            serviceCollection.AddTransient<IAuthService, AuthService>();
            serviceCollection.AddTransient<ICategoryService, CategoryService>();
            serviceCollection.AddTransient<IChatService, ChatService>();
            serviceCollection.AddTransient<ILiqPayService, LiqPayService>();
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
