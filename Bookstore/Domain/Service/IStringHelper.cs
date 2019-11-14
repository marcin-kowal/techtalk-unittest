namespace Bookstore.Domain.Service
{
    public interface IStringHelper
    {
        string MakeFirstLetterCapital(string text);
        string MakeFirstLetterCapitalAndRestLower(string text);
    }
}