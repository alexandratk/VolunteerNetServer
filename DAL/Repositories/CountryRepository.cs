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
    public class CountryRepository : ICountryRepository
    {
        VolunteerNetServerDBContext _context;

        public CountryRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public Task AddAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Country>> GetAllAsync()
        {
            List<Country> countries = await _context.Countries.AsNoTracking().OrderBy(o => o.ISO).ToListAsync();
            return countries;
        }

        public async Task<IEnumerable<CountryTranslation>> GetCountryNamesAsync(string language)
        {
            var countryTranslations = await _context.CountryTranslations.AsNoTracking()
                .Where(r => r.Language == language).OrderBy(o => o.Name).ToListAsync();
            return countryTranslations;
        } 

        public Task<Country?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CountryTranslation?> GetCountryTranslationById(Guid id, string language)
        {
            CountryTranslation? countryTranslation = _context.CountryTranslations.AsNoTracking()
                .Where(r => r.CountryId == id && r.Language == language).FirstOrDefault();
            return Task.FromResult(countryTranslation);
        }

        public Task<CountryTranslation?> getCountryIdByName(string name)
        {
            var countryTranslation = _context.CountryTranslations.AsNoTracking().Where(r => r.Name == name).FirstOrDefault();
            return Task.FromResult(countryTranslation);
        }

        public Task Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
