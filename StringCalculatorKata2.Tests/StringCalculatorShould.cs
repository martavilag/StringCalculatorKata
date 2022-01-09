using Xunit;
using FluentAssertions;

namespace StringCalculatorKata2.Tests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void ReturnZeroWhenStringIsEmpty()
        {
            var emptyString = new StringCalculator("");
            emptyString.Sum().Should().Be(0);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        public void ReturnOneNumberWhenStringHasOneNumber(string input, int output)
        {
            var oneNumber = new StringCalculator(input);
            oneNumber.Sum().Should().Be(output, input);
        }

        [Theory]
        [InlineData("1,0", 1)]
        [InlineData("0,1", 1)]
        [InlineData("2,0", 2)]
        [InlineData("0,2", 2)]
        public void ReturnOneNumberWhenStringIsZeroAndThatSameNumber(string input, int output)
        {
            var oneNumber = new StringCalculator(input);
            oneNumber.Sum().Should().Be(output, input);
        }
    }
}