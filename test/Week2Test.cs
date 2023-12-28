using FluentAssertions;
using solution;

namespace test
{
    public class Week2Test
    {
        [Fact]
        public void AddBinary_ShouldReturnCorrectResult()
        {
            // Arrange
            string a = "11";
            string b = "1";
            string expected = "100";

            // Act
            string result = Week2.AddBinary(a, b);

            // Assert
            result.Should().Be(expected);
        }

        [Fact]
        public void AddBinary_ShouldReturnZero_WhenBothInputsAreZero()
        {
            // Arrange
            string a = "0";
            string b = "0";
            string expected = "0";

            // Act
            string result = Week2.AddBinary(a, b);

            // Assert
            result.Should().Be(expected);
        }

        // Add more test cases here...
    }
}