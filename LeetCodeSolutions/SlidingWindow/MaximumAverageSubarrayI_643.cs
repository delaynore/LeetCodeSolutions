namespace LeetCodeSolutions.SlidingWindow;

internal class MaximumAverageSubarrayI_643
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            var max = int.MinValue;
            var sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (i - k >= 0)
                {
                    sum -= nums[i - k];
                }
                if (i >= k - 1) max = Math.Max(sum, max);
            }

            return max / (double)k;
        }
    }
}
