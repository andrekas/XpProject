using RoleAndParty.Aids;

namespace RoleAndParty.Classes
{
    public class RelationshipType
    {
        public string name;
        public string description;

        public string Gender
        {
            get { return Str.EmptyIfNull(name); }
            set { name = value; }
        }

        public string Description
        {
            get { return Str.EmptyIfNull(description); }
            set { description = value; }
        }
    }
}