namespace LeetCodeSolutions.StackQueue;

internal class P0933_NumberOfRecentCalls
{
    public class RecentCounter
    {
        private readonly LinkedList<int> _q = new();
        private const int Window = 3000;

        public int Ping(int t)
        {
            _q.AddLast(t);
            var threshold = t - Window;

            while (_q.First?.Value < threshold)
            {
                _q.RemoveFirst();
            }

            return _q.Count;
        }
    }
}
