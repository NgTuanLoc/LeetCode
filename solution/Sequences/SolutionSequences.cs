using System.Collections;

namespace solution.Sequences
{
    public static class SolutionSequences
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            // https://leetcode.com/problems/two-sum/
            var table = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (table.ContainsKey(nums[i]))
                {
                    return new int[] { table[nums[i]], i };
                }
                else if (!table.ContainsKey(target - nums[i]))
                {
                    table.Add(target - nums[i], i);
                }
            }
            return nums;
        }
        public static int MaxProductSubArray(int[] nums)
        {
            // https://leetcode.com/problems/maximum-product-subarray/description/
            int n = nums.Length;
            int max = nums[0];
            int p = 1;
            int q = 1;

            for (int i = 0; i < n; i++)
            {
                p = (p == 0 ? 1 : p) * nums[i];
                q = (q == 0 ? 1 : q) * nums[n - i - 1];
                max = Math.Max(max, Math.Max(p, q));
            }

            return max;
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            // https://leetcode.com/problems/contains-duplicate/
            Hashtable table = new Hashtable();
            foreach (var item in nums)
            {
                if (table.ContainsKey(item)) return true;
                table.Add(item, true);
            }
            return false;
        }
        public static int MaxProfit(int[] prices)
        {
            // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
            if (prices.Length == 0) return 0;

            int max = 0;
            int buy = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (buy > prices[i]) buy = prices[i];
                max = Math.Max(max, prices[i] - buy);
            }

            return max;
        }
        public static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> dic = new();

            foreach (var item in s)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item] += 1;
                    continue;
                }
                dic[item] = 1;
            }

            foreach (var item in t)
            {
                if (!dic.ContainsKey(item)) return false;

                if (dic[item] == 1)
                {
                    dic.Remove(item);
                    continue;
                }
                dic[item] -= 1;
            }

            return dic.Keys.Count == 0;
        }
        public static bool IsValidParentheses(string s)
        {
            // https://leetcode.com/problems/valid-parentheses/
            if (s.Length == 1) return false;
            Dictionary<char, char> parenthesesDict = new();
            string data = "(){}[]";

            for (int i = 0; i < data.Length; i += 2)
            {
                parenthesesDict.Add(data[i], data[i + 1]);
            }


            Stack<char> stack = new();

            foreach (var item in s)
            {
                if (parenthesesDict.ContainsKey(item))
                {
                    stack.Push(item);
                }
                else
                {
                    if (stack.Count == 0) return false;
                    var openBracket = stack.Pop();
                    if (parenthesesDict[openBracket] != item) return false;
                }
            }
            return stack.Count == 0;
        }
        public static int MaxSubArray(int[] nums)
        {
            // https://leetcode.com/problems/maximum-subarray/
            int max = nums[0];
            int sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum < nums[i]) sum = nums[i];
                max = Math.Max(max, sum);
            }

            return max;
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            // https://leetcode.com/problems/product-of-array-except-self/
            int n = nums.Length;
            var result = new int[n];
            int temp = 1;

            for (int i = 0; i < n; i++)
            {
                result[i] = temp;
                temp *= nums[i];
            }

            temp = 1;

            for (int i = n - 1; i >= 0; i--)
            {
                result[i] *= temp;
                temp *= nums[i];
            }

            return result;
        }
    }
}