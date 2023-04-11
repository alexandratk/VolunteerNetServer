using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public static class ApplicationStatuses
    {
        public static Dictionary<int, Dictionary<string, string>> StatusTranslation = new Dictionary<int, Dictionary<string, string>>()
        {
            {0, new Dictionary<string, string>()
                {
                    { "en", "checking" },
                    { "uk", "оброблюється" }
                }
            },
            {1, new Dictionary<string, string>()
                {
                    { "en", "in progress" },
                    { "uk", "в процесі" }
                }
            },
            {2, new Dictionary<string, string>()
                {
                    { "en", "completed" },
                    { "uk", "завершено" }
                }
            }
        };

        public enum Status 
        { 
            Processing = 0,
            InProgress = 1,
            Сompleted = 2
        }
    }
}
