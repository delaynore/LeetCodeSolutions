using System.Text;

namespace LeetCodeSolutions.StackQueue;

internal class P1047_RemoveAllAdjacentDuplicatesInString
{
    public class Solution
    {
        public string RemoveDuplicates(string s)
        {
            var stack = new StringBuilder(20);
            stack.Insert(0, s[0]);
            var current = 0;
            for (var i = 1; i < s.Length; i++)
            {
                if (current >= 0 && stack[current] == s[i])
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
