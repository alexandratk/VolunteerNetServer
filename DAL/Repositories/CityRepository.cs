using DAL.Data;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.Repositories
{
    public class CityRepository : ICityRepository
    {
        VolunteerNetServerDBContext _context;

        public CityRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(City entity)
        {
            _context.Cities.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeCityTranslationsAsync(List<CityTranslation> entities)
        {
            _context.CityTranslations.AddRange(entities);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(City entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<City?> GetByIdAsync(Guid id)
        {
            City? city = _context.Cities.AsNoTracking()
                .Where(r => r.Id == id).Include("Country").FirstOrDefault();
            return Task.FromResult(city);
        }

        public Task<CityTranslation?> GetCityTranslationById(Guid id, string language)
        {
            CityTranslation? cityTranslation = _context.CityTranslations.Include("City").AsNoTracking()
                .Where(r => r.CityId == id && r.Language == language).FirstOrDefault();
            return Task.FromResult(cityTranslation);
        }

        public async Task<IEnumerable<CityTranslation>> GetCityNamesByCountryNameAsync(Guid countryId, string language)
        {
            var cityTranslations = await _context.CityTranslations.Include("City").AsNoTracking()
                .Where(r => r.Language == language && r.City.CountryId == countryId).OrderBy(o => o.Name).ToListAsync();
            return cityTranslations;
        }

        public Task<CityTranslation?> GetByNameAsync(string name)
        {
            CityTranslation? cityTranslation = _context.CityTranslations
                .Include("City").Include("City.Country").AsNoTracking().Where(r => r.Name == name).FirstOrDefault();
            return Task.FromResult(cityTranslation);
        }

        public Task Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
