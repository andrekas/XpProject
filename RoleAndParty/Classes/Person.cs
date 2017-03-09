using RoleAndParty.Aids;
using System;

namespace RoleAndParty.Classes
{
    public class Person
    {
        private string name;
        public static DateTime MinDateOfBirth => new DateTime(1900, 1, 1);
        public static DateTime MaxDateOfBirth => new DateTime(2100, 1, 1);
        private DateTime dateOfBirth = MinDateOfBirth;

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
        //public DateTime DateOfBirth
        //{
        //    get { return DateOfBirth; }
        //    set { DateOfBirth = value; }
        //}

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (value < MinDateOfBirth) return;
                if (value > MaxDateOfBirth) return;
                dateOfBirth = value;
            }
        }

        public PersonName getPersonName()
        {
            PersonNames.GetPersonName(name);
            ///return?
            return new PersonName();
        }

        //public PersonName getPersonEthnicity()
        //{
        //    Ethnicities.GetPersonEthnicity(name);
        //    ///return?
        //    return new Ethnicity();
        //}

        //public ISOGender getPersonGender()
        //{
        //    ISOGender.;

        //}

        //public ISOGender Gender { get; set; }

    }
}
