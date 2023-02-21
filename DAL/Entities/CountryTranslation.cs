using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CountryTranslation : BaseEntity
    {
        public string Language { get; set; }

        public string Name { get; set; }

        public Guid CountryId { get; set; }
        public Country Country { get; set; }
    }
}
