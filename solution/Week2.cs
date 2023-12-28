using System.Text;

namespace solution;

public class Week2
{
    public static string AddBinary(string a, string b)
    {
        // https://leetcode.com/problems/add-binary/description/
        var stringBuilder = new StringBuilder();
        int carry = 0;

        for (int i = a.Length - 1, j = b.Length - 1; i >= 0 || j >= 0; i--, j--)
        {
            int valueA = i >= 0 ? a[i] - '0' : 0;
            int valueB = j >= 0 ? b[j] - '0' : 0;
            int sum = valueA + valueB + carry;

            if (sum > 1)
            {
                carry = 1;
                stringBuilder.Insert(0, sum % 2);
                continue;
            }

            carry = 0;
            stringBuilder.Insert(0, sum);
        }

        if (carry == 1) stringBuilder.Insert(0, carry);

        return stringBuilder.ToString();
    }

    public static int AddDigits(int num)
    {
        // https://leetcode.com/problems/add-digits/description/
        if (num < 10) return num;

        while (num > 9)
        {
            List<char> temp = num.ToString().ToList();
            num = 0;
            foreach (var item in temp)
            {
                num += item - '0';
            }
        }

        return num;
    }

    public static string AddStrings(string num1, string num2)
    {
        // https://leetcode.com/problems/add-strings/
        int carry = 0;
        StringBuilder stringBuilder = new();

        for (int i = num1.Length - 1, j = num2.Length - 1; i >= 0 || j >= 0; i--, j--)
        {
            int valueA = i >= 0 ? num1[i] - '0' : 0;
            int valueB = j >= 0 ? num2[j] - '0' : 0;
            int sum = valueA + valueB + carry;

            if (sum > 9)
            {
                stringBuilder.Insert(0, sum % 10);
                carry = 1;
                continue;
            }

            stringBuilder.Insert(0, sum);
            carry = 0;
        }

        if (carry == 1) stringBuilder.Insert(0, carry);

        return stringBuilder.ToString();
    }


    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // https://leetcode.com/problems/median-of-two-sorted-arrays/description/
        int i = 0;
        int j = 0;
        List<int> data = new();
        int numberOfItems = nums1.Length + nums2.Length;
        int midIndex = (int)Math.Floor((double)(numberOfItems / 2));

        while (i + j != midIndex + 1)
        {
            if (i == nums1.Length || j == nums2.Length) break;
            if (nums1[i] <= nums2[j])
            {
                data.Add(nums1[i]);
                i++;
            }
            else
            {
                data.Add(nums2[j]);
                j++;
            }
        }

        if (i != nums1.Length)
        {
            data = data.Concat(nums1.Skip(i)).ToList();
        }
        if (j != nums2.Length)
        {
            data = data.Concat(nums2.Skip(j)).ToList();
        }


        if (numberOfItems % 2 == 1)
        {
            return data[midIndex];
        }


        return (double)(data[midIndex - 1] + data[midIndex]) / 2;
    }
    public static int MinimumTotal(IList<IList<int>> triangle)
    {
        // https://leetcode.com/problems/triangle/
        int result = 0;
        foreach (var row in triangle)
        {
            int min = row[0];
            foreach (var item in row)
            {
                if (min > item) min = item;
            }
            result += min;
        }
        return result;
    }
}
