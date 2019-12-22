using Bookstore.Domain.Service;
using FluentAssertions;
using Xunit;

namespace Bookstore.Tests.Domain.Service
{
    public class StringHelperTests
    {
        [Theory]
        [InlineData("abc", "Abc")]
        [InlineData("aBC", "ABC")]
        [InlineData("", "")]
        //[InlineData(null, "")]
        public void MakeFirstLetterCapitalTest(
            string text,
            string expected)
        {
            var helper = new StringHelper();

            var actual = helper.MakeFirstLetterCapital(text);

            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData("aBC", "Abc")]
        [InlineData("ABC", "Abc")]
        [InlineData("", "")]
        //[InlineData(null, "")]
        public void MakeFirstLetterCapitalAndLowerOthersTest(
            string text,
            string expected)
        {
            var helper = new StringHelper();

            var actual = helper.MakeFirstLetterCapitalAndLowerOthers(text);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}