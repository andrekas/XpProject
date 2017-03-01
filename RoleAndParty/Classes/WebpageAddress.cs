using RoleAndParty.Aids;

namespace RoleAndParty.Classes
{
    public class WebpageAddress
    {
        public string url;

        public string Url
        {
            get { return Str.EmptyIfNull(url); }
            set { url = value; }
        }
    }
}