using DAL.Data;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task DeleteAsync(ProfilePicture entity)
        {
            _context.ProfilePictures.Remove(entity);
            await _context.SaveChangesAsync();
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

        public Task<ProfilePicture?> GetByUserIdAsync(Guid userId)
        {
            var profilePicture = _context.ProfilePictures.AsNoTracking().Where(x => x.UserId == userId).FirstOrDefault();
            return Task.FromResult(profilePicture);
        }

        public async Task UpdateAsync(ProfilePicture entity)
        {
            _context.ProfilePictures.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
