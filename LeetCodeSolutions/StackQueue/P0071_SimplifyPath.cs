using System.Text;

namespace LeetCodeSolutions.StackQueue;

internal class P0071_SimplifyPath
{
    public class Solution
    {
        public string SimplifyPath(string path)
        {
            var p = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            var stack = new LinkedList<string>();
            foreach (var dir in p)
            {
                if (dir == ".") continue;
                if (dir == "..")
                {
                    if (stack.Count > 0)
                        stack.RemoveLast();
                    continue;
                }
                stack.AddLast(dir);
            }

            var builder = new StringBuilder();
            return
                builder
                    .Append('/')
                    .AppendJoin('/', stack)
                    .ToString();
        }
    }
}
