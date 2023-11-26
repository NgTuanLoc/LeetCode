namespace Namespace;
using FluentAssertions;
using solution.Week1;

public class Week1Test
{
    [Fact]
    public void TwoSumTest()
    {
        // Arrange
        var input1 = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
        var input2 = new int[] { 3, 2, 4 };
        var input3 = new int[] { 3, 3 };

        // Act
        var result1 = Week1.TwoSum(input1, 11);
        var result2 = Week1.TwoSum(input2, 6);
        var result3 = Week1.TwoSum(input3, 6);

        // Assert
        result1.Should().Equal(new int[] { 5, 11 });
        result2.Should().Equal(new int[] { 1, 2 });
        result3.Should().Equal(new int[] { 0, 1 });
    }
    [Fact]
    public void LongestCommonPrefixTest()
    {
        // Arrange
        string[] input1 = { "flower", "flow", "flight" };
        string[] input2 = { "" };
        string[] input3 = { "dog", "racecar", "car" };

        // Act
        var result1 = Week1.LongestCommonPrefix(input1);
        var result2 = Week1.LongestCommonPrefix(input2);
        var result3 = Week1.LongestCommonPrefix(input3);

        // Assert
        result1.Should().Be("fl");
        result2.Should().Be("");
        result3.Should().Be("");
    }
    [Fact]
    public void ZigZagTest()
    {
        // Act
        var result1 = Week1.Convert("PAYPALISHIRING", 3);
        var result2 = Week1.Convert("PAYPALISHIRING", 4);
        var result3 = Week1.Convert("AB", 1);

        // Assert
        result1.Should().Be("PAHNAPLSIIGYIR");
        result2.Should().Be("PINALSIGYAHRPI");
        result3.Should().Be("AB");
    }
    [Fact]
    public void LengthOfLongestSubstringTest()
    {
        // Act
        var result1 = Week1.LengthOfLongestSubstring("abcabcbb");
        var result2 = Week1.LengthOfLongestSubstring("bbbbb");
        var result3 = Week1.LengthOfLongestSubstring("pwwkew");
        var result4 = Week1.LengthOfLongestSubstring("dvdf");

        // Act
        // Assert
        result1.Should().Be(3);
        result2.Should().Be(1);
        result3.Should().Be(3);
        result4.Should().Be(3);
    }
    [Fact]
    public void MaxAreaTest()
    {
        // Act
        var result1 = Week1.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        var result2 = Week1.MaxArea(new int[] { 1, 1 });
        var result3 = Week1.MaxArea(new int[] { 1, 2, 1 });
        // Assert
        result1.Should().Be(49);
        result2.Should().Be(1);
        result3.Should().Be(2);
    }
}
