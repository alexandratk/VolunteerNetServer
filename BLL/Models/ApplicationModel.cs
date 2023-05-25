using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ApplicationModel : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Status { get; set; }

        public string Type { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string Kind { get; set; }

        public int RequiredNumberOfVolunteers { get; set; }

        public int NumberOfVolunteers { get; set; }

        public DateTime DateTimeStart { get; set; }

        public DateTime DateTimeEnd { get; set; }

        public Guid UserId { get; set; }
        public UserModel User { get; set; }

        public List<ApplicationDocumentModel> ApplicationDocuments { get; set; } =
            new List<ApplicationDocumentModel>();
    }
}
