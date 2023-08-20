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
    }
}