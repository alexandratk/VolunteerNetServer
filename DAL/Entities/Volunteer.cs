using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Volunteer : BaseEntity
    {
        public int Status { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("ApplicationId")]
        public Application Application { get; set; }
        public Guid ApplicationId { get; set; }

        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
