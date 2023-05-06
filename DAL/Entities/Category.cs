using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Category : BaseEntity
    {
        public string Title { get; set; }

        public List<Application> Applications { get; set; } = new List<Application>();
        public List<CategoryTranslation> CategoryTranslations { get; set; } = new List<CategoryTranslation>();
    }
}
