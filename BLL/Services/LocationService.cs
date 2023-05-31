using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LocationService : ILocationService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;

        public LocationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ValidationResult>> AddCountryAsync(CountryCreationModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (model == null)
            {
                validationResults.Add(new ValidationResult("invalidData"));
                return validationResults;
            }

            Country newCountry = new Country();
            newCountry.Id = Guid.NewGuid();
            newCountry.ISO = model.ISO;

            await unitOfWork.CountryRepository.AddAsync(newCountry);

            List<CountryTranslation> newCountryTranslations = new List<CountryTranslation>();

            CountryTranslation newCountryTranslationEn = new CountryTranslation();
            newCountryTranslationEn.Id = Guid.NewGuid();
            newCountryTranslationEn.Language = Languages.LanguagesEnum.en.ToString();
            newCountryTranslationEn.Name = model.NameEn;
            newCountryTranslationEn.CountryId = newCountry.Id;

            CountryTranslation newCountryTranslationUk = new CountryTranslation();
            newCountryTranslationUk.Id = Guid.NewGuid();
            newCountryTranslationUk.Language = Languages.LanguagesEnum.uk.ToString();
            newCountryTranslationUk.Name = model.NameUk;
            newCountryTranslationUk.CountryId = newCountry.Id;

            CountryTranslation newCountryTranslationPl = new CountryTranslation();
            newCountryTranslationPl.Id = Guid.NewGuid();
            newCountryTranslationPl.Language = Languages.LanguagesEnum.pl.ToString();
            newCountryTranslationPl.Name = model.NamePl;
            newCountryTranslationPl.CountryId = newCountry.Id;

            newCountryTranslations.Add(newCountryTranslationEn);
            newCountryTranslations.Add(newCountryTranslationUk);
            newCountryTranslations.Add(newCountryTranslationPl);

            await unitOfWork.CountryRepository
                .AddRangeCountryTranslationsAsync(newCountryTranslations);
            return validationResults;
        }

        public async Task<List<ValidationResult>> AddCityAsync(CityCreationModel model)
        {
            var validationResults = new List<ValidationResult>();
            if (model == null)
            {
                validationResults.Add(new ValidationResult("invalidData"));
                return validationResults;
            }

            City newCity = new City();
            newCity.Id = Guid.NewGuid();
            newCity.CountryId = model.CountryId;
            newCity.ISO = model.ISO;

            await unitOfWork.CityRepository.AddAsync(newCity);

            List<CityTranslation> newCityTranslations = new List<CityTranslation>();

            CityTranslation newCityTranslationEn = new CityTranslation();
            newCityTranslationEn.Id = Guid.NewGuid();
            newCityTranslationEn.Language = Languages.LanguagesEnum.en.ToString();
            newCityTranslationEn.Name = model.NameEn;
            newCityTranslationEn.CityId = newCity.Id;

            CityTranslation newCityTranslationUk = new CityTranslation();
            newCityTranslationUk.Id = Guid.NewGuid();
            newCityTranslationUk.Language = Languages.LanguagesEnum.uk.ToString();
            newCityTranslationUk.Name = model.NameUk;
            newCityTranslationUk.CityId = newCity.Id;

            CityTranslation newCityTranslationPl = new CityTranslation();
            newCityTranslationPl.Id = Guid.NewGuid();
            newCityTranslationPl.Language = Languages.LanguagesEnum.pl.ToString();
            newCityTranslationPl.Name = model.NamePl;
            newCityTranslationPl.CityId = newCity.Id;

            newCityTranslations.Add(newCityTranslationEn);
            newCityTranslations.Add(newCityTranslationUk);
            newCityTranslations.Add(newCityTranslationPl);

            await unitOfWork.CityRepository
                .AddRangeCityTranslationsAsync(newCityTranslations);
            return validationResults;
        }

        public async Task<IEnumerable<CountryViewModel>> GetCountryNamesAsync(string language)
        {
            var countries = await unitOfWork.CountryRepository.GetCountryNamesAsync(language);
            var countryNames = mapper.Map<IEnumerable<CountryTranslation>, IEnumerable<CountryViewModel>>(countries);
            return countryNames;
        }

        public async Task<IEnumerable<CityViewModel>> GetCityNamesByCountryAsync(string language, string countryName)
        {
            var country = await unitOfWork.CountryRepository.getCountryIdByName(countryName);
            var cities = await unitOfWork.CityRepository.GetCityNamesByCountryNameAsync(country.CountryId, language);
            var cityNames = mapper.Map<IEnumerable<CityTranslation>, IEnumerable<CityViewModel>>(cities);
            return cityNames;
        }
    }
}
