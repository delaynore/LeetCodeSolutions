namespace LeetCodeSolutions.TwoPointers;

internal class MoveZeroes_283
{
    public void MoveZeroes(int[] nums)
    {
        var x = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[x]) = (nums[x], nums[i]);
                x++;
            }
        }
    }
}
