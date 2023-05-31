using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class CityCreationModel
    {
        public string ISO { get; set; }

        public Guid CountryId { get; set; }

        public string NameEn { get; set; }

        public string NameUk { get; set; }

        public string NamePl { get; set; }
    }
}
