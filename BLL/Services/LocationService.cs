﻿using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<CountryViewModel>> GetCountryNamesAsync(CountryFiltrModel countryFiltrModel)
        {
            var countries = await unitOfWork.CountryRepository.GetCountryNamesAsync(countryFiltrModel.Language);
            var countryNames = mapper.Map<IEnumerable<CountryTranslation>, IEnumerable<CountryViewModel>>(countries);
            return countryNames;
        }

        public async Task<IEnumerable<CityViewModel>> GetCityNamesByCountryAsync(CitiesFiltrModel citiesFiltrModel)
        {
            var country = await unitOfWork.CountryRepository.getCountryIdByName(citiesFiltrModel.CountryName);
            var cities = await unitOfWork.CityRepository.GetCityNamesByCountryNameAsync(country.CountryId, citiesFiltrModel.Language);
            var cityNames = mapper.Map<IEnumerable<CityTranslation>, IEnumerable<CityViewModel>>(cities);
            return cityNames;
        }
    }
}
