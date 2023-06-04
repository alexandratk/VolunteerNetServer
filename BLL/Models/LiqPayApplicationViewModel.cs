using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class LiqPayApplicationViewModel
    {
        public ApplicationViewModel Application { get; set; }

        public List<LiqPayDonateModel> Donations { get; set; } = new List<LiqPayDonateModel>();
    }
}
