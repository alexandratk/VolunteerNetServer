using DAL.Data;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProfilePictureRepository : IProfilePictureRepository
    {
        VolunteerNetServerDBContext _context;

        public ProfilePictureRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(ProfilePicture entity)
        {
            _context.ProfilePictures.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(ProfilePicture entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProfilePicture>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProfilePicture?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProfilePicture entity)
        {
            throw new NotImplementedException();
        }
    }
}
