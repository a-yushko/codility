using System.Diagnostics;

namespace Assesment.LinkedList
{
    /// <summary>
    /// Singly linked list
    /// </summary>
    [DebuggerDisplay("Count={Count}")]
    public class LinkedList
    {
        public LinkedList(Node head)
        {
            _head = head;
        }

        public Node Head => _head;

        public int Count
        {
            get
            {
                int count = 0;
                Node n = _head;
                while(n != null)
                {
                    count++;
                    n = n.Next;
                }
                return count;
            }
        }

        public bool Contains(Node node)
        {
            Node n = _head;
            while(n != null)
            {
                if (n.Value == node.Value)
                    return true;
                n = n.Next;
            }
            return false;
        }

        /// <summary>
        /// Remove duplicates from an unsorted linked list.
        /// </summary>
        public void RemoveDuplicates()
        {
            Node current = _head;
            while(current != null)
            {
                RemoveDuplicatesHelper(current, current);
                current = current.Next;
            }
        }

        private void RemoveDuplicatesHelper(Node head, Node value)
        {
            if (head == null || value == null)
                return;
            Node current = head;
            while(current.Next != null)
            {
                if (current.Next.Value == value.Value)
                    current.Next = current.Next.Next;
                else
                    current = current.Next;
            }
        }

        Node _head;
    }
}
