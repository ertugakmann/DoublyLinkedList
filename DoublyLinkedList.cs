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

        public Node DeleteLastNode()
        {
            if (length == 0)
                return null;

            Node temp = tail;

            if ( length == 1)
            {
                head = null;
                tail = null;
            }
            else 
            {
                tail = tail.prev;
                tail.next = null;
                temp.prev = null;
            }

            length--;
            return temp;
            
        }

        public Node DeleteFirstNode()
        {
            if (length == 0)
                return null;


            Node temp = head;


            if (length == 1)
            {
                head = null;
                tail = null;

                return head;
            }
            else
            {
                head = head.next;

                temp.next = null;
                head.prev = null;       
            }
            return temp;
            length--;

        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            if(length == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }

            length++;
        }

       
        public Node GetNode(int index)
        {
            if (index < 0 || index > length)
                return null;

            Node temp = head;

            if(index < length / 2)
            {
                for(int i = 0; index > i; i++)
                {
                    temp = temp.next;
                }
            }
            else
            {
                temp = tail;

                for (int i = length - 1; i > index; i--)
                {
                    temp = temp.prev;
                }
            }
            return temp;
        }

        public void SetNode(int index, int data)
        {
            if(index >= 0 && index < length)
            {
                Node temp = GetNode(index);

                temp.data = data; 
            }
            else
            {
                Console.WriteLine("Please enter a valid index number..");
            }
        }

        public bool InsertNode(int data, int index)
        {
            if (index < 0 || index > length)
                return false;

            if (index == length) 
            {
                AppendList(data);
                return true;
            }
                

            if(index == 0)
            {
                AddFirst(data);
                return true;
            }

            Node newNode = new Node(data);
            Node prevNode = GetNode(index - 1);
            Node nextNode = GetNode(index);

            prevNode.next = newNode;
            newNode.prev = prevNode;

            newNode.next = nextNode;
            nextNode.prev = newNode;
            length++;
            return true;
                
        }

        public Node DeleteNode(int index)
        {
            Node deleteNode = GetNode(index);

            if (index >= 0 && index < length)
            {
                if (index == 0)
                {
                    DeleteFirstNode();
                }
                else if (index == length)
                {
                    DeleteLastNode();
                }
                else
                {
                    deleteNode.next.prev = deleteNode.prev;
                    deleteNode.prev.next = deleteNode.next;

                    deleteNode.next = null;
                    deleteNode.prev = null;
                    length--;
                }
            }
            else
            {
                return null;
            }
            return deleteNode;
        }
    }
}
