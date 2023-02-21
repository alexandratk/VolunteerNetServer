using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICountryRepository : IRepository<Country>
    {
        Task<IEnumerable<CountryTranslation>> GetCountryNamesAsync(string language);

        Task<CountryTranslation?> GetCountryTranslationById(Guid id, string language);

        Task<CountryTranslation?> getCountryIdByName(string name);
    }
}
