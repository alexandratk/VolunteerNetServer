using DAL.Interfaces;
using DAL.Repositories;

namespace DAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public VolunteerNetServerDBContext Context { get; }

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
                    applicationRepository = new ApplicationRepository(Context);
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
                    categoryRepository = new CategoryRepository(Context);
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
                    cityRepository = new CityRepository(Context);
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
                    countryRepository = new CountryRepository(Context);
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
                    donateRepository = new DonateRepository(Context);
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
                    messageRepository = new MessageRepository(Context);
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
                    notificationRepository = new NotificationRepository(Context);
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
                    profilePictureRepository = new ProfilePictureRepository(Context);
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
                    skillRepository = new SkillRepository(Context);
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
                    userRepository = new UserRepository(Context);
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
                    userSkillRepository = new UserSkillRepository(Context);
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
                    volunteerRepository = new VolunteerRepository(Context);
                }
                return volunteerRepository;
            }
        }

        public UnitOfWork(VolunteerNetServerDBContext context)
        {
            this.Context = context;
        }

        public async Task SaveAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
