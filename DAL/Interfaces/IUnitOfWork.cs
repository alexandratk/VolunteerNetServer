using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IApplicationRepository ApplicationRepository { get; }

        ICategoryRepository CategoryRepository { get; }

        ICityRepository CityRepository { get; }

        ICountryRepository CountryRepository { get; }

        IMessageRepository MessageRepository { get; }
        
        IProfilePictureRepository ProfilePictureRepository { get; }

        ISkillRepository SkillRepository { get; }
        
        IUserRepository UserRepository { get; }

        IUserSkillRepository UserSkillRepository { get; }

        IVolunteerRepository VolunteerRepository { get; }
    }
}
