using RoleAndParty.Aids;

namespace RoleAndParty.Classes
{
    public class WebpageAddress
    {
        private string url;

        public string Url
        {
            get { return Str.EmptyIfNull(url); }
            set { url = value; }
        }
    }
}