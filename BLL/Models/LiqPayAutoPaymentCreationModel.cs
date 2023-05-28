using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class LiqPayAutoPaymentCreationModel
    {
        public double Sum { get; set; }

        public List<Guid> ApplicationIds { get; set; } = new List<Guid>();
    }
}
