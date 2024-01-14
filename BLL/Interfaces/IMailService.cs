using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IMailService
    {
        Task<bool> SendMail(string destination, string topic, string body);
    }
}
