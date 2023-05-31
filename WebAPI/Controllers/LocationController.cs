using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;

namespace WebAPI.Controllers
{
    [Authorize]
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

        [Authorize(Roles = "admin")]
        [HttpPost("add/country")]
        public async Task<ActionResult> AddCountry([FromForm] CountryCreationModel value)
        {
            try
            {
                var validationResults = await locationService.AddCountryAsync(value);
                if (validationResults.IsNullOrEmpty())
                {
                    return Ok();
                }
                return BadRequest(validationResults);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [Authorize(Roles = "admin")]
        [HttpPost("add/city")]
        public async Task<ActionResult> AddCity([FromForm] CityCreationModel value)
        {
            try
            {
                var validationResults = await locationService.AddCityAsync(value);
                if (validationResults.IsNullOrEmpty())
                {
                    return Ok();
                }
                return BadRequest(validationResults);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [AllowAnonymous]
        [HttpGet("getcountries")]
        public async Task<ActionResult<IEnumerable<CountryViewModel>>> GetListCountries([FromHeader(Name = "Accept-Language")] string language)
        {
            try
            {
                var countryNames = await locationService.GetCountryNamesAsync(language);
                return Ok(countryNames);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }

        [AllowAnonymous]
        [HttpGet("getcities/{country}")]
        public async Task<ActionResult<IEnumerable<CountryViewModel>>> GetListCities([FromHeader(Name = "Accept-Language")] string language, string country)
        {
            try
            {
                var cityNames = await locationService.GetCityNamesByCountryAsync(language, country);
                return Ok(cityNames);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
    }
}
