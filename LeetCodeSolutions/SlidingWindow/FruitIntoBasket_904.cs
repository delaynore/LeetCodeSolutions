namespace LeetCodeSolutions.SlidingWindow;

internal class FruitIntoBasket_904
{
    public class Solution
    {
        public int TotalFruit(int[] fruits)
        {
            const int Size = 2;
            var dict = new Dictionary<int, int>();
            var maxWindowSize = 0;
            var begin = 0;
            for (var end = 0; end < fruits.Length; end++)
            {
                dict[fruits[end]] = dict.TryGetValue(fruits[end], out var value)
                    ? value + 1
                    : 1;

                while (dict.Count > Size)
                {
                    dict[fruits[begin]]--;

                    if (dict.TryGetValue(fruits[begin], out var value1) && value1 == 0)
                    {
                        dict.Remove(fruits[begin]);
                    }
                    begin++;
                }

                maxWindowSize = Math.Max(maxWindowSize, end - begin + 1);
            }

            return maxWindowSize;
        }
    }
}
