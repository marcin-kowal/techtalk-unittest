namespace Bookstore.Domain.Service
{
    public interface IStringHelper
    {
        string MakeFirstLetterCapital(string text);
        string MakeFirstLetterCapitalAndLowerOthers(string text);
    }
}