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

        private UserRepository userRepository;
        private ProfilePictureRepository profilePictureRepository;
        private SkillRepository skillRepository;

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

        //public UnitOfWork()
        //{
        //    context = new PhotoAlbumDbContext();
        //}

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
