namespace LeetCodeSolutions.HashMap;
internal class P0001_TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            foreach (var (index, value) in nums.Index())
            {
                if (dict.TryGetValue(target - value, out var i))
                {
                    return [index, i];
                }
                dict.TryAdd(value, index);
            }

            return [];
        }
    }
}
