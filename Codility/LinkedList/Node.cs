using System.Diagnostics;

namespace Assesment.LinkedList
{
    [DebuggerDisplay("{Value}")]
    public class Node
    {
        public Node(int value)
            :this(value, null)
        {
        }

        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
        }
        public int Value { get; set; }
        public Node Next { get; set; }
    }
}
