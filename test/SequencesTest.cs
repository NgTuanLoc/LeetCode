using solution.Sequences;
using FluentAssertions;

namespace SequencesTest
{
    public class SequencesTest
    {
        [Fact]
        public void TwoSumTest()
        {
            // Arrange
            var test = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            var test1 = new int[] { 3, 2, 4 };
            var test2 = new int[] { 3, 3 };

            // Act
            var result = SolutionSequences.TwoSum(test, 11);
            var result1 = SolutionSequences.TwoSum(test1, 6);
            var result2 = SolutionSequences.TwoSum(test2, 6);

            // Assert
            result.Should().Equal(new int[] { 5, 11 });
            result1.Should().Equal(new int[] { 1, 2 });
            result2.Should().Equal(new int[] { 0, 1 });
        }
        [Fact]
        public void ContainsDuplicateTest()
        {
            // Arrange
            var test = new int[] { 1, 2, 3, 1 };
            var test1 = new int[] { 1, 2, 3, 4 };
            var test2 = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            // Act
            var result = SolutionSequences.ContainsDuplicate(test);
            var result1 = SolutionSequences.ContainsDuplicate(test1);
            var result2 = SolutionSequences.ContainsDuplicate(test2);

            // Assert
            result.Should().Be(true);
            result1.Should().Be(false);
            result2.Should().Be(true);
        }
        [Fact]
        public void MaxProfitTest()
        {
            // Arrange
            var test = new int[] { 7, 1, 5, 3, 6, 4 };
            var test1 = new int[] { 7, 6, 4, 3, 1 };

            // Act
            var result = SolutionSequences.MaxProfit(test);
            var result1 = SolutionSequences.MaxProfit(test1);

            // Assert
            result.Should().Be(5);
            result1.Should().Be(0);
        }
        [Fact]
        public void IsAnagramTest()
        {
            // Arrange
            var test = new int[] { 7, 1, 5, 3, 6, 4 };
            var test1 = new int[] { 7, 6, 4, 3, 1 };

            // Act
            var result = SolutionSequences.MaxProfit(test);
            var result1 = SolutionSequences.MaxProfit(test1);

            // Assert
            result.Should().Be(5);
            result1.Should().Be(0);
        }
        [Fact]
        public void IsValidParenthesesTest()
        {
            // Arrange
            var test = "()";
            var test1 = "()[]{}";
            var test2 = "(]";
            var test3 = "){}";

            // Act
            var result = SolutionSequences.IsValidParentheses(test);
            var result1 = SolutionSequences.IsValidParentheses(test1);
            var result2 = SolutionSequences.IsValidParentheses(test2);
            var result3 = SolutionSequences.IsValidParentheses(test3);

            // Assert
            result.Should().Be(true);
            result1.Should().Be(true);
            result2.Should().Be(false);
            result3.Should().Be(false);
        }
        [Fact]
        public void MaxProductSubArrayTest()
        {
            // Arrange
            var test = new int[] { 1, 2, 3, 4 };
            var test1 = new int[] { 2, 3, -2, 4 };
            var test2 = new int[] { -2, 0, -1 };

            // Act
            var result = SolutionSequences.MaxProductSubArray(test);
            var result1 = SolutionSequences.MaxProductSubArray(test1);
            var result2 = SolutionSequences.MaxProductSubArray(test2);

            // Assert
            result.Should().Be(24);
            result1.Should().Be(6);
            result2.Should().Be(0);
        }
        [Fact]
        public void MaxSubArrayTest()
        {
            // Arrange
            var test = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var test1 = new int[] { 1 };
            var test2 = new int[] { 5, 4, -1, 7, 8 };

            // Act
            var result = SolutionSequences.MaxSubArray(test);
            var result1 = SolutionSequences.MaxSubArray(test1);
            var result2 = SolutionSequences.MaxSubArray(test2);

            // Assert
            result.Should().Be(6);
            result1.Should().Be(1);
            result2.Should().Be(23);
        }
        [Fact]
        public void ProductExceptSelfTest()
        {
            // Arrange
            var test = new int[] { 1, 2, 3, 4 };
            var test1 = new int[] { -1, 1, 0, -3, 3 };

            // Act
            var result = SolutionSequences.ProductExceptSelf(test);
            var result1 = SolutionSequences.ProductExceptSelf(test1);

            // Assert
            result1.Should().Equal(new int[] { 0, 0, 9, 0, 0 });
            result.Should().Equal(new int[] { 24, 12, 8, 6 });
        }
    }
}