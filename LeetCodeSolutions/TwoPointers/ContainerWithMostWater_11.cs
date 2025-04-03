namespace LeetCodeSolutions.TwoPointers;

internal class ContainerWithMostWater_11
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = int.MinValue;

        while (left < right)
        {
            var v = (right - left) * Math.Min(height[left], height[right]);
            maxArea = Math.Max(v, maxArea);

            if (height[left] > height[right])
            {
                right--;
            }
            else left++;
        }

        return maxArea;
    }
}
