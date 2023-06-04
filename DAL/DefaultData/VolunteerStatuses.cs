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
                    { "uk", "оброблюється" },
                    { "pl", "w toku" }
                }
            },
            {1, new Dictionary<string, string>()
                {
                    { "en", "accepted" },
                    { "uk", "прийнято" },
                    { "pl", "zaakceptowany" }
                }
            },
            {2, new Dictionary<string, string>()
                {
                    { "en", "rejected" },
                    { "uk", "відхилено" },
                    { "pl", "odrzucony" }
                }
            },
            {3, new Dictionary<string, string>()
                {
                    { "en", "owner" },
                    { "uk", "власник" },
                    { "pl", "właściciel" }
                }
            },
            {4, new Dictionary<string, string>()
                {
                    { "en", "completed" },
                    { "uk", "закінчено" },
                    { "pl", "ukończony" }
                }
            }
        };

        public enum Status
        {
            Processing = 0,
            Accepted = 1,
            Rejected = 2,
            Owner = 3,
            Completed = 4
        }
    }
}
