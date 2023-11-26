namespace solution.Week1;
public static class Week1
{
    public static int[] TwoSum(int[] num, int target)
    {
        Dictionary<int, int> table = new();

        for (int i = 0; i < num.Length; i++)
        {
            if (table.ContainsKey(target - num[i]))
            {
                return new int[] { table[target - num[i]], i };
            }
            if (table.ContainsKey(num[i])) continue;
            table.Add(num[i], i);
        }

        return Array.Empty<int>();
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        string result = "";
        int i = 0;
        int temp;
        do
        {
            temp = strs.Length - 1;
            if (i == strs[0].Length) break;
            var first = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length) break;
                if (first != strs[j][i]) break;
                temp--;
            }

            if (temp == 0) result += first;

            i++;
        } while (temp == 0);

        return result;
    }
    public static string Convert(string s, int numRows)
    {
        // https://leetcode.com/problems/zigzag-conversion/
        Dictionary<int, string> result = new() { };
        int k = 0;

        if (numRows == 1) return s;

        bool isIncrease = true;

        for (int i = 0; i < s.Length; i++)
        {
            if (!result.ContainsKey(k)) result.Add(k, "");
            result[k] += s[i];

            if (k == numRows - 1) // reach to max
            {
                k--;
                isIncrease = false;
                continue;
            }

            if (k == 0) // reach to min
            {
                k++;
                isIncrease = true;
                continue;
            }

            if (isIncrease) k++;
            if (!isIncrease) k--;
        }

        return string.Join("", result.Values.ToArray());
    }

    public static int LengthOfLongestSubstring(string s)
    {
        // https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
        int max = 0;
        Dictionary<char, int> table = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (!table.ContainsKey(s[i]))
            {
                table.Add(s[i], i);
                max = Math.Max(max, table.Count);
            }
            else
            {
                i = table[s[i]];
                table.Clear();
            }
        }

        return max;
    }

    public static int MaxArea(int[] height)
    {
        // https://leetcode.com/problems/container-with-most-water/
        int startIndex = 0;
        int endIndex = height.Length - 1;
        int result = 0;

        while (startIndex < endIndex)
        {
            int currentMax = (endIndex - startIndex) * Math.Min(height[startIndex], height[endIndex]);
            result = Math.Max(result, currentMax);

            if (height[startIndex] > height[endIndex])
            {
                endIndex--;
            }
            else
            {
                startIndex++;
            }
        }

        return result;
    }
}