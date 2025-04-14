namespace LeetCodeSolutions.StackQueue;

internal class P0020_ValidParentheses
{
    public class Solution
    {
        private static readonly Dictionary<char, char> _dictionary = new()
        {
            {'}', '{'},
            {')', '('},
            {']', '['},
        };

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            stack.Push(s[0]);

            foreach (var c in s.Skip(1))
            {
                if (!_dictionary.TryGetValue(c, out var closeParen))
                {
                    stack.Push(c);
                    continue;
                }

                if (stack.TryPeek(out var peek) && peek == closeParen)
                {
                    stack.Pop();
                    continue;
                }

                return false;
            }

            return stack.Count == 0;
        }
    }
}
