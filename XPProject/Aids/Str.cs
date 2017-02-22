using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XPProject.Aids
{
    public class Str
    {
        public static string EmptyIfNull(string s)
        {
            return string.IsNullOrEmpty(s) ? string.Empty : s;
        }
    }
}