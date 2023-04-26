using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class MessageModel : BaseModel
    {
        public string User { get; set; }

        public string Message { get; set; }
    }
}
