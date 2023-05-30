using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public static class Languages
    {
        public enum LanguagesEnum
        {
            en = 0,
            uk = 1,
            pl = 2
        }

        public static List<string> LanguagesList { get; } = new List<string>()
        {
            "en",
            "uk",
            "pl"
        };
    }
}
