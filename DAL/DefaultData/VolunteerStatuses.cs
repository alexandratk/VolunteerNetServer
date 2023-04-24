using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public class VolunteerStatuses
    {
        public static Dictionary<int, Dictionary<string, string>> StatusTranslation = new Dictionary<int, Dictionary<string, string>>()
        {
            {0, new Dictionary<string, string>()
                {
                    { "en", "processing" },
                    { "uk", "оброблюється" }
                }
            },
            {1, new Dictionary<string, string>()
                {
                    { "en", "accepted" },
                    { "uk", "прийнято" }
                }
            },
            {2, new Dictionary<string, string>()
                {
                    { "en", "rejected" },
                    { "uk", "відхилено" }
                }
            }
        };

        public enum Status
        {
            Processing = 0,
            Accepted = 1,
            Rejected = 2
        }
    }
}
