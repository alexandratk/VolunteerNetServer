using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ILocationService
    {
        Task<List<ValidationResult>> AddCityAsync(CityCreationModel model);

        Task<List<ValidationResult>> AddCountryAsync(CountryCreationModel value);

        Task<IEnumerable<CountryViewModel>> GetCountryNamesAsync(string language);

        Task<IEnumerable<CityViewModel>> GetCityNamesByCountryAsync(string language, string country);
    }
}
