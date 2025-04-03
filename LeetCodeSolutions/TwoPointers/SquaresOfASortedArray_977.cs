namespace LeetCodeSolutions.TwoPointers;

internal class SquaresOfASortedArray_977
{
    public int[] SortedSquares(int[] nums)
    {
        var result = new int[nums.Length];
        var left = 0;
        var right = nums.Length - 1;
        var current = right;

        while (left < right)
        {
            var leftS = nums[left] * nums[left];
            var rightS = nums[right] * nums[right];

            if (leftS > rightS)
            {
                result[current] = leftS;
                left++;
            }
            else
            {
                result[current] = rightS;
                right--;
            }
            current--;
        }

        // after cycle one square left.
        // and cause right == left, choose any
        result[current] = nums[right] * nums[right];

        return result;
    }
}
