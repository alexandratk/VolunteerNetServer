using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        ICityRepository CityRepository { get; }

        ICountryRepository CountryRepository { get; }
        
        IProfilePictureRepository ProfilePictureRepository { get; }

        ISkillRepository SkillRepository { get; }
        
        IUserRepository UserRepository { get; }

        
    }
}
