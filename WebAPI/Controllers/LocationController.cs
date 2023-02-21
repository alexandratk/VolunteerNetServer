using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService locationService;
        private readonly IMapper mapper;

        public LocationController(ILocationService locationService, IMapper mapper)
        {
            this.locationService = locationService;
            this.mapper = mapper;
        }

        [HttpPost("getcountries")]
        public async Task<ActionResult<IEnumerable<CountryViewModel>>> GetListCountries([FromForm] CountryFiltrModel countryFiltrModel)
        {
            try
            {
                var countryNames = await locationService.GetCountryNamesAsync(countryFiltrModel);
                return Ok(countryNames);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [HttpPost("getcities")]
        public async Task<ActionResult<IEnumerable<CountryViewModel>>> GetListCities([FromForm] CitiesFiltrModel citiesFiltrModel)
        {
            try
            {
                var cityNames = await locationService.GetCityNamesByCountryAsync(citiesFiltrModel);
                return Ok(cityNames);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
    }
}
