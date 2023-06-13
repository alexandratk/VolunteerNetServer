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
    public class DonateRepository : IDonateRepository
    {
        VolunteerNetServerDBContext _context;

        public DonateRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Donate entity)
        {
            _context.Donates.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(List<Donate> entities)
        {
            _context.Donates.AddRange(entities);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Donate entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Donate>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Donate>> GetListByApplicationId(Guid applicationId)
        {
            List<Donate> donates = await _context.Donates.Include("Application")
                .Where(x => x.ApplicationId == applicationId).OrderByDescending(x => x.DateTimeCreation)
                .AsNoTracking().ToListAsync();
            return donates;
        }

        public async Task<List<Donate>> GetListDonatesWithTerm(int numberOfDays)
        {
            List<Donate> donates = await _context.Donates.Include("Application")
                .Where(x => x.DateTimeCreation.AddDays(numberOfDays) >= DateTime.Now && 
                x.Application.Status == (int)ApplicationStatuses.Status.Сompleted)
                .OrderByDescending(x => x.DateTimeCreation)
                .AsNoTracking().ToListAsync();
            return donates;
        }

        public async Task<List<Donate>> GetListDonatesWithoutTerm()
        {
            List<Donate> donates = await _context.Donates.Include("Application")
                .Where(x => x.Application.Status == (int)ApplicationStatuses.Status.Сompleted)
                .OrderByDescending(x => x.DateTimeCreation)
                .AsNoTracking().ToListAsync();
            return donates;
        }

        public Task<Donate?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Donate entity)
        {
            throw new NotImplementedException();
        }
    }
}
