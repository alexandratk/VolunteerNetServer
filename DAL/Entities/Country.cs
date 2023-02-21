
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Country :BaseEntity 
    {
        public string ISO { get; set; }

        public List<City> Cities { get; set; }

        public List<CountryTranslation> CountryTranslations { get; set; }
    }
}
