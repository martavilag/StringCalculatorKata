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
    }
}