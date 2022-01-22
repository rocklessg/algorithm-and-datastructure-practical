using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractical
{
    public class SinglyLinkedList
    {
        public Node Head;

        public SinglyLinkedList()
        {
            Head = null;
        }

        public void TransverseList()
        {
            Node head = Head;

            while (head != null)
            {
                Console.WriteLine(head.Value + " ");
                head = head.Next;
            }
        }
    }
}
