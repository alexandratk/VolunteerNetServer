using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Exceptions
{
    [Serializable]
    public class InvalidProfilePictureException : Exception
    {
        public InvalidProfilePictureException() : base("Invalid profile picture") { }
    }
}
