using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int length;
        
        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public DoublyLinkedList(int data)
        {
            Node newNode = new Node(data);

            head = newNode;
            tail = newNode;
            length = 1;
        }

        public void AppendList(int data)
        {
            Node newNode = new Node(data);

            if (length == 0)
            {
              head = newNode;
              tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            length++;
        }

        public void PrintList()
        {
            Node temp = head;
            int indexNumber = 0;
            Console.WriteLine("The nodes of DoublyLinkedList : ");
            Console.WriteLine("- - - - - - - - - - - - - - - - ");

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
                indexNumber++;
            }
        }

        public void PrintLength()
        {
            Console.WriteLine("The length of DoublyLinkedList : " + length);
        }

        public void PrintHead()
        {
            Console.WriteLine("The head of DoublyLinkedList : " + head.data);
        }

        public void PrintTail()
        {
            Console.WriteLine("The tail of DoublyLinkedList : " + tail.data);
        }

    }
}
