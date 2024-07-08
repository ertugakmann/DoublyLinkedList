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


    }
}
