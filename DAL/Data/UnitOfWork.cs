using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public VolunteerNetServerDBContext context { get; set; }

        private ApplicationRepository applicationRepository;
        private CityRepository cityRepository;
        private CountryRepository countryRepository;
        private ProfilePictureRepository profilePictureRepository;
        private SkillRepository skillRepository;
        private UserRepository userRepository;
        private UserSkillRepository userSkillRepository;

        public IApplicationRepository ApplicationRepository
        {
            get
            {
                if (applicationRepository == null)
                {
                    applicationRepository = new ApplicationRepository(context);
                }
                return applicationRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(context);
                }
                return userRepository;
            }
        }

        public IProfilePictureRepository ProfilePictureRepository
        {
            get
            {
                if (profilePictureRepository == null)
                {
                    profilePictureRepository = new ProfilePictureRepository(context);
                }
                return profilePictureRepository;
            }
        }

        public ISkillRepository SkillRepository
        {
            get
            {
                if (skillRepository == null)
                {
                    skillRepository = new SkillRepository(context);
                }
                return skillRepository;
            }
        }

        public ICityRepository CityRepository
        {
            get
            {
                if (cityRepository == null)
                {
                    cityRepository = new CityRepository(context);
                }
                return cityRepository;
            }
        }

        public ICountryRepository CountryRepository
        {
            get
            {
                if (countryRepository == null)
                {
                    countryRepository = new CountryRepository(context);
                }
                return countryRepository;
            }
        }

        public IUserSkillRepository UserSkillRepository
        {
            get
            {
                if (userSkillRepository == null)
                {
                    userSkillRepository = new UserSkillRepository(context);
                }
                return userSkillRepository;
            }
        }

        public UnitOfWork(VolunteerNetServerDBContext context)
        {
            this.context = context;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
