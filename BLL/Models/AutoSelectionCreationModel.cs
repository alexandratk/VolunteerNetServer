using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class AutoSelectionCreationModel
    {
        public decimal Sum { get; set; }

        public List<Guid> CategoryIds { get; set; } = new List<Guid>();
    }
}
