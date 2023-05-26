using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class AutoSelectionViewModel
    {
        public double Sum { get; set; }

        public List<ApplicationViewModel> Applications { get; set; } 
            = new List<ApplicationViewModel>();
    }
}
