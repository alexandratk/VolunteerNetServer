using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ILocationService
    {
        Task<IEnumerable<CountryViewModel>> GetCountryNamesAsync(string language);

        Task<IEnumerable<CityViewModel>> GetCityNamesByCountryAsync(string language, string country);
    }
}
