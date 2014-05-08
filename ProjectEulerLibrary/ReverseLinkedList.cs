using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerLibrary
{
    public class ReverseLinkedList
    {
        private Node Head;
        private int Count;

        public ReverseLinkedList()
        {
            Head = null;
            Count = 0;
        }

        public List<int> Traverse()
        {
            List<int> nodeValues = new List<int>();
            Node temp = Head;
            while (temp != null)
            {
                nodeValues.Add(temp.Value);
                temp = temp.Next;
            }

            return nodeValues;
        }

        public Node Add(int value)
        {
            if (Head == null)
            {
                Head = new Node(value);
                Count++;
            }
            else
            {
                Node temp = Head;
                Head = new Node(value);
                Head.Next = temp;
                Count++;
            }

            // Head will always point to the node that was just added.
            return Head;
        }

        public int GetCount()
        {
            return Count;
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
