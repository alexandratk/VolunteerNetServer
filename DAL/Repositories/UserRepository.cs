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
            _context.Users.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(User entity)
        {
            _context.Users.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllAsync()
        {
            List<User> users = await _context.Users.AsNoTracking().ToListAsync();
            return users;
        }

        public Task<User?> GetByLoginAndPass(string login, string password)
        {
            User? user = _context.Users.AsNoTracking().Where(r => r.Login == login && r.Password == password).FirstOrDefault();
            return Task.FromResult(user);
        }

        public Task<User?> GetByIdAsync(Guid id)
        {
            User? user = _context.Users.AsNoTracking().Where(r => r.Id == id).Include("ProfilePicture").FirstOrDefault();
            return Task.FromResult(user);
        }

        public async Task Update(User entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public bool CheckLogin(string login)
        {
            User? user = _context.Users.AsNoTracking().Where(r => r.Login.Equals(login)).FirstOrDefault();
            return user != null;
        }
    }
}
