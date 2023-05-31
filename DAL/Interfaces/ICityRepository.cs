using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICityRepository : IRepository<City>
    {
        Task AddRangeCityTranslationsAsync(List<CityTranslation> entities);

        Task<CityTranslation?> GetByNameAsync(string name);

        Task<CityTranslation?> GetCityTranslationById(Guid id, string language);

        Task<IEnumerable<CityTranslation>> GetCityNamesByCountryNameAsync(Guid countryId, string language);
    }
}
