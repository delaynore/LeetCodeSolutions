namespace LeetCodeSolutions.TwoPointers;

internal class P0485_MaxConsecutiveOnes
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var zero = 0;
            var max = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    max = Math.Max(max, i - zero);
                    zero = i + 1;
                }
            }

            max = Math.Max(max, nums.Length - zero);

            return max;
        }
    }
}
