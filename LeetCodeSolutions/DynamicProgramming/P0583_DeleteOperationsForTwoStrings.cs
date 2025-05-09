﻿namespace LeetCodeSolutions.DynamicProgramming;

internal class P0583_DeleteOperationsForTwoStrings
{
    public class Solution
    {
        // Algo O(n*m), Space O(n)
        public int MinDistance(string word1, string word2)
        {
            Span<int> prev = stackalloc int[word1.Length + 1];
            Span<int> current = stackalloc int[word1.Length + 1];

            for (var i = 1; i < word1.Length + 1; i++)
            {
                prev[i] = i;
            }

            for (var p2 = 1; p2 < word2.Length + 1; p2++)
            {
                current[0] = p2;
                for (var p1 = 1; p1 < word1.Length + 1; p1++)
                {
                    if (word1[p1 - 1] == word2[p2 - 1])
                    {
                        current[p1] = prev[p1 - 1];
                        continue;
                    }

                    current[p1] = 1 + Math.Min(prev[p1], current[p1 - 1]);
                }

                var tmp = current;
                current = prev;
                prev = tmp;
            }

            return prev[word1.Length];
        }
    }
}
