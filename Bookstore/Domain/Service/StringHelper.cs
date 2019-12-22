using System.Text.RegularExpressions;

namespace Bookstore.Domain.Service
{
    public class StringHelper : IStringHelper
    {
        public string MakeFirstLetterCapital(string text)
        {
            return new Regex("^[a-z]")
                .Replace(
                    text,
                    match => match.Value.ToUpper());
        }

        public string MakeFirstLetterCapitalAndLowerOthers(string text)
        {
            return MakeFirstLetterCapital(
                text.ToLower());
        }
    }
}