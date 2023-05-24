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
