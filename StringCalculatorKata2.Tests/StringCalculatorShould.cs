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
        [InlineData("1,1", 2)]
        [InlineData("2,1", 3)]
        [InlineData("2,1,1", 4)]
        [InlineData("20,1,1,100", 122)]
        public void ReturnSumSequenceNumbersIgnoringTheComma(string input, int output)
        {
            var oneNumber = new StringCalculator(input);
            oneNumber.Sum().Should().Be(output, input);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("0,4\n3,1", 8)]
        public void ReturnSumSequenceNumbersIgnoringTheCommasAndNewLines(string input, int output)
        {
            var oneNumber = new StringCalculator(input);
            oneNumber.Sum().Should().Be(output, input);
        }
    }
}