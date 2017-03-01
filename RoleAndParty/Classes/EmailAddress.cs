using RoleAndParty.Aids;

namespace RoleAndParty.Classes
{
    public class EmailAddress
    {
        private string email;

        public string Email
        {
            get { return Str.EmptyIfNull(email); }
            set { email = value; }
        }
    }
}