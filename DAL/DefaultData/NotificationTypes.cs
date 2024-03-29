﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public static class NotificationTypes
    {
        public enum TypesEnum
        {
            ApproveApplication = 0,
            ForbidApplication = 1,
            AcceptVolunteer = 2,
            RejectVolunteer = 3,
            RemoveVolunteer = 4,
            ExitVolunteer = 5,
            CompleteApplication = 6,
            DeleteApplication = 7
        }

        public static List<string> Types { get; set; }
            = new List<string>() { 
                "approveApplication",
                "forbidApplication",
                "acceptVolunteer",
                "rejectVolunteer",
                "removeVolunteer",
                "exitVolunteer",
                "completeVolunteer",
                "deleteVolunteer"
            };
    }
}
