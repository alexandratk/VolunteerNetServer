using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public class Locations
    {
        const int NumberOfCountries = 2;
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<CountryTranslation> CountryTranslations { get; set; } = new List<CountryTranslation>();
        
        const int NumberOfCities = 24;
        public List<City> Cities { get; set; } = new List<City>();
        public List<CityTranslation> CityTranslations { get; set; } = new List<CityTranslation>();

        public Locations()
        {
            List<Guid> countryIds = new List<Guid>();
            for (int i = 0; i < NumberOfCountries; i++)
            {
                countryIds.Add(Guid.NewGuid());
            }

            Countries.AddRange(
                new Country[]
                {
                    new Country() { Id = countryIds[0], ISO = "uk" },
                    new Country() { Id = countryIds[1], ISO = "pl" }
                });

            CountryTranslations.AddRange(
                new CountryTranslation[]
                {
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "en", CountryId = countryIds[0], Name = "Ukraine" },
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "uk", CountryId = countryIds[0], Name = "Україна" },
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "en", CountryId = countryIds[1], Name = "Poland" },
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "uk", CountryId = countryIds[1], Name = "Польша" },
                });


            List<Guid> cityIds = new List<Guid>();
            for (int i = 0; i < NumberOfCities; i++)
            {
                cityIds.Add(Guid.NewGuid());
            }

            Cities.AddRange(
                new City[]
                {
                    new City { Id = cityIds[0], CountryId = countryIds[0], ISO = "vi" },
                    new City { Id = cityIds[1], CountryId = countryIds[0], ISO = "dn" },
                    new City { Id = cityIds[2], CountryId = countryIds[0], ISO = "zhy" },
                    new City { Id = cityIds[3], CountryId = countryIds[0], ISO = "zp" },
                    new City { Id = cityIds[4], CountryId = countryIds[0], ISO = "if" },
                    new City { Id = cityIds[5], CountryId = countryIds[0], ISO = "ky" },
                    new City { Id = cityIds[6], CountryId = countryIds[0], ISO = "kr" },
                    new City { Id = cityIds[7], CountryId = countryIds[0], ISO = "lut" },
                    new City { Id = cityIds[8], CountryId = countryIds[0], ISO = "lv" },
                    new City { Id = cityIds[9], CountryId = countryIds[0], ISO = "my" },
                    new City { Id = cityIds[10], CountryId = countryIds[0], ISO = "od" },
                    new City { Id = cityIds[11], CountryId = countryIds[0], ISO = "pol" },
                    new City { Id = cityIds[12], CountryId = countryIds[0], ISO = "ri" },
                    new City { Id = cityIds[13], CountryId = countryIds[0], ISO = "su" },
                    new City { Id = cityIds[14], CountryId = countryIds[0], ISO = "ter" },
                    new City { Id = cityIds[15], CountryId = countryIds[0], ISO = "uzh" },
                    new City { Id = cityIds[16], CountryId = countryIds[0], ISO = "khar" },
                    new City { Id = cityIds[17], CountryId = countryIds[0], ISO = "kher" },
                    new City { Id = cityIds[18], CountryId = countryIds[0], ISO = "khm" },
                    new City { Id = cityIds[19], CountryId = countryIds[0], ISO = "chk" },
                    new City { Id = cityIds[20], CountryId = countryIds[0], ISO = "chv" },
                    new City { Id = cityIds[21], CountryId = countryIds[0], ISO = "chh" },
                    new City { Id = cityIds[22], CountryId = countryIds[1], ISO = "var" },
                    new City { Id = cityIds[23], CountryId = countryIds[1], ISO = "lub" }
                });

            CityTranslations.AddRange(
               new CityTranslation[]
               {
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[0], Name = "Вінниця"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[1], Name = "Дніпро"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[2], Name = "Житомир"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[3], Name = "Запоріжжя"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[4], Name = "Івано-Франківськ"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[5], Name = "Київ"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[6], Name = "Кропивницький"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[7], Name = "Луцьк"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[8], Name = "Львів"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[9], Name = "Миколаїв"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[10], Name = "Одеса"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[11], Name = "Полтава"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[12], Name = "Рівне"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[13], Name = "Суми"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[14], Name = "Тернопіль"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[15], Name = "Ужгород"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[16], Name = "Харків"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[17], Name = "Херсон"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[18], Name = "Хмельницький"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[19], Name = "Черкаси"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[20], Name = "Чернівці"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[21], Name = "Чернігів"},

                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[0], Name = "Vinnytsia"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[1], Name = "Dnipro"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[2], Name = "Zhytomyr"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[3], Name = "Zaporizhzhia"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[4], Name = "Ivano-Frankivsk"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[5], Name = "Kyiv"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[6], Name = "Kropyvnytskyi"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[7], Name = "Lutsk"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[8], Name = "Lviv"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[9], Name = "Mykolaiv"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[10], Name = "Odesa"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[11], Name = "Poltava"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[12], Name = "Rivne"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[13], Name = "Sumy"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[14], Name = "Ternopil"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[15], Name = "Uzhhorod"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[16], Name = "Kharkiv"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[17], Name = "Kherson"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[18], Name = "Khmelnytskyi"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[19], Name = "Cherkasy"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[20], Name = "Chernivtsi"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[21], Name = "Chernihiv"},

                    
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[22], Name = "Варшава"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[23], Name = "Люблін"},

                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[22], Name = "Varshava"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[23], Name = "Lublin"},

               });
        }
        
    }
}
