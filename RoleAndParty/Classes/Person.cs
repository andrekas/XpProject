using RoleAndParty.Aids;
using System;

namespace RoleAndParty.Classes
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

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

        //public PersonName getPersonName()
        //{
        //    PersonNames.GetPersonName(name);
        //}

        //public ISOGender getPersonGender()
        //{
        //    ISOGender.G
            
        //}

    }
}
