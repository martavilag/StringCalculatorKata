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

        [Fact]
        public void ReturnOneWhenStringIsOne()
        {
            var stringOne = new StringCalculator("1");
            stringOne.Sum().Should().Be(1);
        }
    }
}