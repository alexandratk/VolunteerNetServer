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
        private CategoryRepository categoryRepository;
        private CityRepository cityRepository;
        private CountryRepository countryRepository;
        private DonateRepository donateRepository;
        private MessageRepository messageRepository;
        private NotificationRepository notificationRepository;
        private ProfilePictureRepository profilePictureRepository;
        private SkillRepository skillRepository;
        private UserRepository userRepository;
        private UserSkillRepository userSkillRepository;
        private VolunteerRepository volunteerRepository;

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

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository(context);
                }
                return categoryRepository;
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

        public IDonateRepository DonateRepository
        {
            get
            {
                if (donateRepository == null)
                {
                    donateRepository = new DonateRepository(context);
                }
                return donateRepository;
            }
        }

        public IMessageRepository MessageRepository
        {
            get
            {
                if (messageRepository == null)
                {
                    messageRepository = new MessageRepository(context);
                }
                return messageRepository;
            }
        }

        public INotificationRepository NotificationRepository
        {
            get
            {
                if (notificationRepository == null)
                {
                    notificationRepository = new NotificationRepository(context);
                }
                return notificationRepository;
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

        public IVolunteerRepository VolunteerRepository
        {
            get
            {
                if (volunteerRepository == null)
                {
                    volunteerRepository = new VolunteerRepository(context);
                }
                return volunteerRepository;
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
