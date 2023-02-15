using DAL.Data;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infrastructure
{
    public class DataAccessLayerConfiguratior
    {
        public static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserRepository, UserRepository>();
            serviceCollection.AddTransient<IProfilePictureRepository, ProfilePictureRepository>();
            serviceCollection.AddTransient<ISkillRepository, SkillRepository>();
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();

        }
    }
}
