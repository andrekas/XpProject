using RoleAndParty.Aids;

namespace RoleAndParty.Classes
{
    public class RelationshipType
    {
        private string name;
        private string description;

        public string Name
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