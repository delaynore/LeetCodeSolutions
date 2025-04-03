namespace LeetCodeSolutions.TwoPointers;

internal class TwoSumII_167
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;
        while (left < right)
        {
            var diff = target - numbers[left];
            if (diff == numbers[right])
            {
                break;
            }
            else if (diff < numbers[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return [left + 1, right + 1];
    }
}
