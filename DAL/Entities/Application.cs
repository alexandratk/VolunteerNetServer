using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Application : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        
        public int Status { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
