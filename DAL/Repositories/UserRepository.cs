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
    public class UserRepository : IUserRepository
    {
        VolunteerNetServerDBContext _context;

        public UserRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User entity)
        {
            entity.Id = Guid.NewGuid();
            _context.Users.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllAsync()
        {
            List<User> users = await _context.Users.ToListAsync();
            return users;
        }

        public Task<User?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
