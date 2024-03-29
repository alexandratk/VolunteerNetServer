﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DefaultData
{
    public class ApplicationKinds
    {
        public enum KindsEnum
        {
            Monetary = 0,
            Volunteer = 1,
            Mixed = 2
        }

        public static List<string> Kinds { get; set; }
            = new List<string>() { "monetary", "volunteer", "mixed" };

        public static List<string> KindsUk { get; set; }
            = new List<string>() { "грошовий", "волонтерський", "змішаний" };

        public static List<string> KindsPl { get; set; }
            = new List<string>() { "pieniężny", "wolontariusz", "mieszany" };
    }
}
