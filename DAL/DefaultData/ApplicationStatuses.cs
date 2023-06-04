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
                    { "uk", "оброблюється" },
                    { "pl", "w toku" }
                }
            },
            {1, new Dictionary<string, string>()
                {
                    { "en", "in progress" },
                    { "uk", "в процесі" },
                    { "pl", "w procesie" }
                }
            },
            {2, new Dictionary<string, string>()
                {
                    { "en", "completed" },
                    { "uk", "завершено" },
                    { "pl", "ukończony" }
                }
            },
            {3, new Dictionary<string, string>()
                {
                    { "en", "forbidden" },
                    { "uk", "заборонено" },
                    { "pl", "zabroniony" }
                }
            }
        };

        public enum Status 
        { 
            Processing = 0,
            InProgress = 1,
            Сompleted = 2,
            Forbidden = 3
        }
    }
}
