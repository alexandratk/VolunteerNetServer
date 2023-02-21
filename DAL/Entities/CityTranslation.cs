using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CityTranslation : BaseEntity
    {
        public string Language { get; set; }

        public string Name { get; set; }

        public Guid CityId { get; set; }
        public City City { get; set; }
    }
}
