using FluentAssertions;
using solution.Easy;

namespace test.Easy
{
    public class RomanToIntegerTest
    {
        [Fact]
        public void ShouldReturn_3()
        {
            string input = "III";

            var result = RomanToInteger.Solution(input);
            result.Should().Be(3);
        }
        [Fact]
        public void ShouldReturn_58()
        {
            string input = "LVIII";

            var result = RomanToInteger.Solution(input);
            result.Should().Be(58);
        }
        [Fact]
        public void ShouldReturn_1994()
        {
            string input = "MCMXCIV";

            var result = RomanToInteger.Solution(input); result.Should().Be(1994);
        }
        [Fact]
        public void ShouldReturn_1695()
        {
            string input = "MDCXCV";

            var result = RomanToInteger.Solution(input); result.Should().Be(1695);
        }
    }
}