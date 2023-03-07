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
    public class UserSkillRepository : IUserSkillRepository
    {
        VolunteerNetServerDBContext _context;

        public UserSkillRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(UserSkill entity)
        {
            _context.UserSkills.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(UserSkill entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserSkill>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserSkill>> GetListUserSkillByUserId(Guid userId)
        {
            var userSkills = _context.UserSkills.Include("Skill").AsNoTracking().Where(x => x.UserId == userId).ToList();
            return Task.FromResult(userSkills);
        }

        public Task<UserSkill?> GetByIdAsync(Guid id)
        {
            var userSkill = _context.UserSkills.Where(x => x.Id == id).FirstOrDefault();
            return Task.FromResult(userSkill);
        }

        public UserSkill? GetById(Guid id)
        {
            var userSkill = _context.UserSkills.Where(x => x.Id == id).FirstOrDefault();
            return userSkill;
        }

        public Task Update(UserSkill entity)
        {
            throw new NotImplementedException();
        }
    }
}
