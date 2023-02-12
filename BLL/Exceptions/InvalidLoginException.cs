using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Exceptions
{
    [Serializable]
    public class InvalidLoginException : Exception
    {
        public InvalidLoginException() : base("Invalid login exception") { }
    }
}
