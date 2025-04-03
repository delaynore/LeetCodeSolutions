namespace LeetCodeSolutions.SlidingWindow;

internal class MinimumSizeSubarraySum_209
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            var begin = 0;
            var windowSize = int.MaxValue;
            var windowSum = 0;
            for (var end = 0; end < nums.Length; end++)
            {
                windowSum += nums[end];

                while (windowSum >= target)
                {
                    windowSize = Math.Min(windowSize, end - begin + 1);
                    windowSum -= nums[begin];
                    begin++;
                }
            }

            return windowSize == int.MaxValue ? 0 : windowSize;
        }
    }
}
