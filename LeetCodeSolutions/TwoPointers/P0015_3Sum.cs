namespace LeetCodeSolutions.TwoPointers;

internal class P0015_3Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var list = new HashSet<(int X, int Y, int Z)>();

        for (var i = 0; i < nums.Length; i++)
        {
            var target = -nums[i];
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                var currentSum = nums[left] + nums[right];
                if (currentSum == target)
                {
                    list.Add((nums[i], nums[left], nums[right]));
                }

                if (currentSum > target)
                {
                    right--;
                }
                else left++;

            }
        }

        return [.. list.Select(IList<int> (x) => [x.X, x.Y, x.Z])];
    }
}
