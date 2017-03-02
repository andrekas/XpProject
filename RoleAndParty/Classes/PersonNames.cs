using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleAndParty.Classes
{
    public class PersonNames: Archetypes<PersonName>
    {
        public static PersonNames Instances { get; } = new PersonNames();

        public static PersonName GetPersonName(string name)
        {
            return Instances.ToList().Find(x => x.Name == name);
        } 
    }
}
