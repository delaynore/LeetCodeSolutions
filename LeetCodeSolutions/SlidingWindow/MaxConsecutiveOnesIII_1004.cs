namespace LeetCodeSolutions.SlidingWindow;

internal class MaxConsecutiveOnesIII_1004
{
    public class Solution
    {
        public int LongestOnes(int[] nums, int k)
        {
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
                maxWindowSize = Math.Max(maxWindowSize, end - begin + 1);
            }
            return maxWindowSize;
        }
    }
}
