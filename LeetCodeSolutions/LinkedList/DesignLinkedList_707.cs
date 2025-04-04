namespace LeetCodeSolutions.LinkedList;

internal class DesignLinkedList_707
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }
    }

    public class MyLinkedList
    {
        public int Count { get; private set; }
        public Node? Head { get; private set; }
        public Node? Tail { get; private set; }

        public MyLinkedList()
        {
            Count = 0;
        }

        public int Get(int index)
        {
            var node = GetNode(index);
            return node is null 
                ? -1 
                : node.Value;
        }

        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        public void AddAtTail(int val)
        {
            AddAtIndex(Count, val);
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                Head = new Node()
                {
                    Value = val,
                    Next = Head
                };
                Count++;
                return;
            }

            var node = GetNode(index - 1);

            if (node is null) return;

            node.Next = new Node()
            {
                Value = val,
                Next = node.Next
            };

            if (node == Tail)
            {
                Tail = node.Next;
            }
            Count++;
        }

        public void DeleteAtIndex(int index)
        {
            if (Count == 0) return;
            if (index == 0)
            {
                Head = Head!.Next;
                Count--;
                return;
            }

            var node = GetNode(index - 1);

            if (node is null || node.Next is null) return;

            if (node.Next.Next is null)
            {
                Tail = node;
            }

            node.Next = node.Next.Next;
            Count--;
        }

        private Node? GetNode(int index)
        {
            if(IsInvalidIndex(index)) return null;

            var current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current!.Next;
            }
            return current;
        }

        private bool IsInvalidIndex(int index)
        {
            return index < 0 || index >= Count;
        }
    }
}
