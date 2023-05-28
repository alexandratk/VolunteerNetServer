using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Donate : BaseEntity
    {
        public string Status { get; set; }

        public double Amount { get; set; }

        public string Description { get; set; }

        public string Action { get; set; }

        public string SenderCardBank { get; set; }

        public int SenderCardCountry { get; set; }

        public string SenderCardMask2 { get; set; }

        public string SenderCardType { get; set; }

        public double SenderCommission { get; set; }

        public DateTime DateTimeCreation { get; set; }

        public Guid? ApplicationId { get; set; }

        public Application? Application { get; set; }
    }
}
