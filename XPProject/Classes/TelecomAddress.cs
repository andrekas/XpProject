using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XPProject
{
    public class TelecomAddress
    {
        public string AreaCode { get; set; }
        public string CountryCode { get; set; }
        public string Extension { get; set; }
        public string NationalDirectDialingPrefix { get; set; }
        public string Number { get; set; }
        public string PhysicalType { get; set; }
    }
}