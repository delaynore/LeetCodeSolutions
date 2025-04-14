namespace LeetCodeSolutions.HashMap;

internal class P0706_DesignHashMap
{
    public class Node
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public Node? Next { get; set; }
    }

    public class LinkedList
    {
        private readonly Node _dummy = new();

        public Node? Head => _dummy.Next;

        public void Insert(int key, int value)
        {
            _dummy.Next = new Node()
            {
                Key = key,
                Value = value,
                Next = _dummy.Next,
            };
        }

        public Node? Find(int key)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Key == key) break;
                current = current.Next;
            }

            return current;
        }

        public void Remove(int key)
        {
            var current = _dummy;

            while (current?.Next != null)
            {
                if (current.Next.Key != key)
                {
                    current = current.Next;
                    continue;
                }

                current.Next = current.Next.Next;
                return;
            }
        }
    }

    public class MyHashMap
    {

        private readonly LinkedList?[] _buckets = new LinkedList[DefaultCapacity];

        private const int DefaultCapacity = 1001;

        private static int GetIndex(int key) => key % DefaultCapacity;

        public void Put(int key, int value)
        {
            var index = GetIndex(key);

            _buckets[index] ??= new LinkedList();

            var bucket = _buckets[index]!;

            var existed = bucket.Find(key);
            if (existed == null)
            {
                bucket.Insert(key, value);
                return;
            }

            existed.Value = value;
        }

        public int Get(int key)
        {
            var index = GetIndex(key);

            var bucket = _buckets[index];

            if (bucket == null) return -1;

            var existed = bucket.Find(key);
            return existed?.Value ?? -1;
        }

        public void Remove(int key)
        {
            var index = GetIndex(key);

            var bucket = _buckets[index];

            bucket?.Remove(key);
        }
    }
}
