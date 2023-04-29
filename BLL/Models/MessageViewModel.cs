using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class MessageViewModel : BaseModel
    {
        public string Text { get; set; }

        public DateTime DateTime { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
