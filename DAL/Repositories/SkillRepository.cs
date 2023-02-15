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
    public class SkillRepository : ISkillRepository
    {
        VolunteerNetServerDBContext _context;

        public SkillRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Skill entity)
        {
            _context.Skills.Add(entity);
            await _context.SaveChangesAsync();
        }
         
        public async Task DeleteAsync(Skill entity)
        {
            _context.Skills.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Skill>> GetAllAsync()
        {
            List<Skill> skills = await _context.Skills.AsNoTracking().ToListAsync();
            return skills;
        }

        public Task<Skill?> GetByIdAsync(Guid id)
        {
            Skill? skill = _context.Skills.AsNoTracking().Where(r => r.Id == id).FirstOrDefault();
            return Task.FromResult(skill);
        }

        public async Task Update(Skill entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
