namespace LeetCodeSolutions.SlidingWindow;

internal class LongestSubarrayOf1AfterDeletingOneElement_1493
{
    public class Solution
    {
        public int LongestSubarray(int[] nums)
        {
            const int k = 1;
            var begin = 0;
            var maxWindowSize = int.MinValue;
            var zeroCounter = 0;
            for (var end = 0; end < nums.Length; end++)
            {
                if (nums[end] == 0)
                {
                    zeroCounter++;
                }
                while (zeroCounter > k)
                {
                    if (nums[begin] == 0)
                    {
                        zeroCounter--;
                    }
                    begin++;
                }
                maxWindowSize = Math.Max(maxWindowSize, end - begin); // must delete one element, even if there is no 0
            }
            return maxWindowSize;
        }
    }
}
