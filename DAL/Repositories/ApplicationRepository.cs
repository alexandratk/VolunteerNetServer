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

        public async Task AddDocumentAsync(ApplicationDocument entity)
        {
            _context.ApplicationDocuments.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Application entity)
        {
            _context.Applications.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Application>> GetAllAsync()
        {
            List<Application> applications = await _context.Applications.Include("ApplicationSkills")
                .OrderByDescending(x => x.DateTimeStart).ThenBy(x => x.Status).AsNoTracking().ToListAsync();
            return applications;
        }

        public Task<Application?> GetByIdAsync(Guid id)
        {
            Application? application = _context.Applications.AsNoTracking()
                .Where(r => r.Id == id).Include("User").Include("ApplicationSkills")
                .Include("ApplicationDocuments").Include("ApplicationPictures").FirstOrDefault();
            return Task.FromResult(application);
        }

        public Task<Application?> GetByIdWithVolunteersAsync(Guid id)
        {
            Application? application = _context.Applications.AsNoTracking()
                .Where(r => r.Id == id).Include("Volunteers").FirstOrDefault();
            return Task.FromResult(application);
        }

        public Task<Application?> GetByIdWithoutForeignAsync(Guid id)
        {
            Application? application = _context.Applications.AsNoTracking()
                .Where(r => r.Id == id).FirstOrDefault();
            return Task.FromResult(application);
        }

        public ApplicationDocument? GetDocumentById(Guid id)
        {
            ApplicationDocument? applicationDocument = _context.ApplicationDocuments.AsNoTracking()
                .Where(r => r.Id == id).FirstOrDefault();
            return applicationDocument;
        }

        public async Task<List<Application>> GetListForAutoPayment(List<Guid> categoryIds)
        {
            List<Application> applications = await _context.Applications
                .Where(x => categoryIds.Contains(x.CategoryId) &&
                x.Status == (int)ApplicationStatuses.Status.InProgress &&
                (x.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Monetary] ||
                x.Kind == ApplicationKinds.Kinds[(int)ApplicationKinds.KindsEnum.Mixed]))
                .AsNoTracking().OrderBy(x => x.RequiredSum - x.CurrentSum).ToListAsync();
            return applications;
        }

        public async Task<List<Application>> GetListForProcessingAsync()
        {
            List<Application> applications = await _context.Applications
                .Where(x => x.Status == (int) ApplicationStatuses.Status.Processing)
                .OrderByDescending(x => x.DateTimeStart).AsNoTracking().ToListAsync();
            return applications;
        }

        public async Task<List<Application>> GetListForUserAsync(Guid userId)
        {
            List<Application> applications = await _context.Applications
                .Where(x => x.UserId == userId).Include("ApplicationSkills")
                .OrderByDescending(x => x.DateTimeStart).ThenBy(x => x.Status).AsNoTracking().ToListAsync();
            return applications;
        }

        public async Task<List<Application>> GetListWithCurrentData()
        {
            List<Application> applications = await _context.Applications
                .Where(x => x.DateTimeEnd <= DateTime.Now && 
                x.Status == (int)ApplicationStatuses.Status.InProgress).AsNoTracking().ToListAsync();
            return applications;
        }

        public async Task Update(Application entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRange(List<Application> entities)
        {
            _context.UpdateRange(entities);
            await _context.SaveChangesAsync();
        }
    }
}
