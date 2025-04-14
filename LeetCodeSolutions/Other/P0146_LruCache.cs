namespace LeetCodeSolutions.Other;

internal class P0146_LruCache
{
    public class Node
    {
        public int Key { get; set; }
        public int Value { get; set; }

        public Node? Next { get; set; }
        public Node? Previous { get; set; }
    }

    public class LinkedList
    {
        private readonly Node _dummyHead;
        private readonly Node _dummyTail;

        public Node? Head => _dummyHead.Next;

        public Node? Tail => _dummyTail.Previous;

        public LinkedList()
        {
            _dummyHead = new();
            _dummyTail = new();

            _dummyHead.Next = _dummyTail;
            _dummyTail.Previous = _dummyHead;
        }

        public Node Insert(int key, int value)
        {
            var tmp = _dummyHead.Next;
            _dummyHead.Next = new Node()
            {
                Key = key,
                Value = value,
                Next = tmp,
                Previous = _dummyHead
            };

            tmp!.Previous = _dummyHead.Next;

            return Head!;
        }

        public void Remove(Node node)
        {
            var prev = node.Previous;
            var next = node.Next;

            prev!.Next = next;
            next!.Previous = prev;
        }

        public int RemoveLast()
        {
            if (Head == _dummyTail) return -1;

            var key = Tail!.Key;

            var prev = Tail.Previous;

            prev!.Next = _dummyTail;
            _dummyTail.Previous = prev;
            return key;
        }
    }

    public class LRUCache
    {
        private readonly int _capacity;
        private readonly Dictionary<int, Node> _dict = new();
        private readonly LinkedList _linkedList = new();

        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            var isExist = _dict.TryGetValue(key, out var node);

            if (!isExist)
            {
                return -1;
            }

            var nodeValue = node!.Value;

            _linkedList.Remove(node!);
            _dict[key] = _linkedList.Insert(key, nodeValue);

            return nodeValue;
        }

        public void Put(int key, int value)
        {
            if (_dict.TryGetValue(key, out var node))
            {
                _linkedList.Remove(node);
                _dict.Remove(key);
                _dict.Add(key, _linkedList.Insert(key, value));
                return;
            }

            if (_dict.Count == _capacity)
            {
                var key1 = _linkedList.RemoveLast();
                _dict.Remove(key1);
            }
            _dict.Add(key, _linkedList.Insert(key, value));
        }
    }
}
