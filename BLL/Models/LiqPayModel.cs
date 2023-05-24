using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class LiqPayModel : BaseModel
    {
        public string Status { get; set; }

        public string Data { get; set; }

        public string Signature { get; set; }

        public double Amount { get; set; }

        public string Description { get; set; }

        public string Action { get; set; }

        public string SenderCardBank { get; set; }

        public int SenderCardCountry { get; set; }

        public string SenderCardMask2 { get; set; }

        public string SenderCardType { get; set; }

        public double SenderCommission { get; set; }

        public string EndDate { get; set; }

        public string OrderId { get; set; }
    }
}
