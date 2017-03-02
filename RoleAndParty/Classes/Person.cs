using System;

namespace RoleAndParty.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }

    }
}
