using AutoMapper;
using Azure.Communication.Email;
using BLL.BackgroundServices;
using BLL.Helpers;
using BLL.Interfaces;
using BLL.Models.Options;
using BLL.Services;
using DAL.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Infrastructure
{
    public class BusinessLogicLayerConfigurator
    {
        public static void ConfigureServices(IServiceCollection serviceCollection, IConfiguration configuration)
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
            serviceCollection.AddTransient<IMailService, MailService>();

            serviceCollection.AddTransient<EmailClient>((_) =>
            {
                string emailClientConnectionString = configuration.GetConnectionString("Mail");
                return new EmailClient(emailClientConnectionString);
            });

            serviceCollection.Configure<EmailOptions>(configuration.GetSection("EmailOptions"));
            serviceCollection.Configure<ResetPasswordOptions>(configuration.GetSection("ResetPasswordOptions"));

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutomapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            serviceCollection.AddSingleton(mapper);
        }
    }
}
