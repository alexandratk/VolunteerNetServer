using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CategoryTranslation : BaseEntity
    {
        public string Language { get; set; }

        public string Name { get; set; }

        public string DescriptionCategory { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
