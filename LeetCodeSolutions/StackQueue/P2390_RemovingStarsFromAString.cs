using System.Text;

namespace LeetCodeSolutions.StackQueue;

internal class P2390_RemovingStarsFromAString
{
    public class Solution
    {
        public string RemoveStars(string s)
        {
            var stack = new StringBuilder(10);
            stack.Insert(0, s[0]);
            var current = 0;
            for (var i = 1; i < s.Length; i++)
            {
                if ('*' == s[i])
                {
                    stack.Remove(current, 1);
                    current--;
                    continue;
                }

                current++;
                stack.Append(s[i]);
            }

            return stack.ToString();
        }
    }
}
