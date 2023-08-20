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
            result.Should().Equal(new int[] { 0, 1 });
            result1.Should().Equal(new int[] { 1, 2 });
            result2.Should().Equal(new int[] { 0, 1 });
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
    }
}