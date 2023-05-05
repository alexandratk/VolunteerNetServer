using DAL.Data;
using DAL.DefaultData;
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
    public class ApplicationRepository : IApplicationRepository
    {
        VolunteerNetServerDBContext _context;

        public ApplicationRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Application entity)
        {
            _context.Applications.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Application entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Application>> GetAllAsync()
        {
            List<Application> applications = await _context.Applications
                .AsNoTracking().ToListAsync();
            return applications;
        }

        public Task<Application?> GetByIdAsync(Guid id)
        {
            Application? application = _context.Applications.AsNoTracking()
                .Where(r => r.Id == id).Include("User").Include("ApplicationSkills").FirstOrDefault();
            return Task.FromResult(application);
        }

        public async Task<List<Application>> GetListForProcessingAsync()
        {
            List<Application> applications = await _context.Applications
                .Where(x => x.Status == (int) ApplicationStatuses.Status.Processing)
                .AsNoTracking().ToListAsync();
            return applications;
        }

        public async Task<List<Application>> GetListForUserAsync(Guid userId)
        {
            List<Application> applications = await _context.Applications
                .Where(x => x.UserId == userId).AsNoTracking().ToListAsync();
            return applications;
        }

        public async Task Update(Application entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
