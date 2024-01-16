using DAL.Entities;

namespace DAL.DefaultData
{
    public class Locations
    {
        const int NumberOfCountries = 2;
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<CountryTranslation> CountryTranslations { get; set; } = new List<CountryTranslation>();
        
        const int NumberOfCities = 40;
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
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "pl", CountryId = countryIds[0], Name = "Ukraina" },
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "en", CountryId = countryIds[1], Name = "Poland" },
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "uk", CountryId = countryIds[1], Name = "Польща" },
                    new CountryTranslation() { Id = Guid.NewGuid(), Language = "pl", CountryId = countryIds[1], Name = "Polska" }
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
                    new City { Id = cityIds[23], CountryId = countryIds[1], ISO = "lub" },

                    new City { Id = cityIds[24], CountryId = countryIds[1], ISO = "bydcz"},
                    new City { Id = cityIds[25], CountryId = countryIds[1], ISO = "tor"},
                    new City { Id = cityIds[26], CountryId = countryIds[1], ISO = "gor"},
                    new City { Id = cityIds[27], CountryId = countryIds[1], ISO = "zie"},
                    new City { Id = cityIds[28], CountryId = countryIds[1], ISO = "lod"},
                    new City { Id = cityIds[29], CountryId = countryIds[1], ISO = "kra"},
                    new City { Id = cityIds[30], CountryId = countryIds[1], ISO = "wro"},
                    new City { Id = cityIds[31], CountryId = countryIds[1], ISO = "opo"},
                    new City { Id = cityIds[32], CountryId = countryIds[1], ISO = "rze"},
                    new City { Id = cityIds[33], CountryId = countryIds[1], ISO = "biaok"},
                    new City { Id = cityIds[34], CountryId = countryIds[1], ISO = "gda"},
                    new City { Id = cityIds[35], CountryId = countryIds[1], ISO = "kat"},
                    new City { Id = cityIds[36], CountryId = countryIds[1], ISO = "kie"},
                    new City { Id = cityIds[37], CountryId = countryIds[1], ISO = "ols"},
                    new City { Id = cityIds[38], CountryId = countryIds[1], ISO = "poz"},
                    new City { Id = cityIds[39], CountryId = countryIds[1], ISO = "szc"},
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

                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[0], Name = "Vinnytsia"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[1], Name = "Dnipro"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[2], Name = "Zhytomyr"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[3], Name = "Zaporizhzhia"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[4], Name = "Ivano-Frankivsk"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[5], Name = "Kyiv"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[6], Name = "Kropyvnytskyi"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[7], Name = "Lutsk"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[8], Name = "Lviv"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[9], Name = "Mykolaiv"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[10], Name = "Odesa"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[11], Name = "Poltava"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[12], Name = "Rivne"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[13], Name = "Sumy"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[14], Name = "Ternopil"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[15], Name = "Uzhhorod"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[16], Name = "Kharkiv"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[17], Name = "Kherson"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[18], Name = "Khmelnytskyi"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[19], Name = "Cherkasy"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[20], Name = "Chernivtsi"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[21], Name = "Chernihiv"},

                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[22], Name = "Варшава"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[23], Name = "Люблін"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[24], Name = "Бидгощ"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[25], Name = "Торунь"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[26], Name = "Гожув-Великопольський"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[27], Name = "Зелена Гура"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[28], Name = "Лодзь"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[29], Name = "Краків"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[30], Name = "Вроцлав"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[31], Name = "Ополе"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[32], Name = "Ряшів"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[33], Name = "Білосток"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[34], Name = "Гданськ"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[35], Name = "Катовиці"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[36], Name = "Кельці"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[37], Name = "Ольштин"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[38], Name = "Познань"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "uk", CityId = cityIds[39], Name = "Щецин"},

                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[22], Name = "Varshava"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[23], Name = "Lublin"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[24], Name = "Bydgoszcz"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[25], Name = "Torun"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[26], Name = "Gorzow Wielkopolski"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[27], Name = "Zielona Gora"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[28], Name = "Lodz"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[29], Name = "Krakow"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[30], Name = "Wroclaw"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[31], Name = "Opole"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[32], Name = "Rzeszow"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[33], Name = "Bialystok"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[34], Name = "Gdansk"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[35], Name = "Katowice"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[36], Name = "Kielce"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[37], Name = "Olsztyn"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[38], Name = "Poznan"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "en", CityId = cityIds[39], Name = "Szczecin"},

                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[22], Name = "Warszawa"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[23], Name = "Lublin"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[24], Name = "Bydgoszcz"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[25], Name = "Toruń"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[26], Name = "Gorzów Wielkopolski"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[27], Name = "Zielona Góra"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[28], Name = "Łódź"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[29], Name = "Kraków"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[30], Name = "Wrocław"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[31], Name = "Opole"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[32], Name = "Rzeszów"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[33], Name = "Białystok"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[34], Name = "Gdańsk"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[35], Name = "Katowice"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[36], Name = "Kielce"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[37], Name = "Olsztyn"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[38], Name = "Poznań"},
                    new CityTranslation() { Id = Guid.NewGuid(), Language = "pl", CityId = cityIds[39], Name = "Szczecin"}

               });
        }
        
    }
}
