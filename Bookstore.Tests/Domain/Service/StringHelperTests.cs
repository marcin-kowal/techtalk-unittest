using Bookstore.Domain.Service;
using FluentAssertions;
using Xunit;

namespace Bookstore.Tests.Domain.Service
{
    public class StringHelperTests
    {
        [Theory]
        [InlineData("abc", "Abc")]
        //""
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
        //""
        public void MakeFirstLetterCapitalAndRestLowerTest(
            string text,
            string expected)
        {
            var helper = new StringHelper();

            var actual = helper.MakeFirstLetterCapitalAndRestLower(text);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}