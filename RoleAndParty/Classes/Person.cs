using RoleAndParty.Aids;
using System;

namespace RoleAndParty.Classes
{
    public class Person
    {
        public string Name { get; set; }
        private string gender;
        public string Gender
        {
            get { return Str.EmptyIfNull(gender); }
            set { gender = value; }
        }
        public DateTime DateOfBirth
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }

    }
}
