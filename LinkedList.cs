using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LinkedList;

namespace LinkedList
{
    internal class LinkedList
    {
        internal Node head;
        internal void Addlast(int data)
        {
            Node newNode = new Node(data);

            if (this.head == null)
            {
                this.head = newNode;

            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = (Node)temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted in to Linked list", newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("Display of Nodes");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write("" + temp.data + " ");
                    temp = (Node)temp.next;

                }
            }
        }
        public void AddAtfirst(int data)
        {
            Node newNode1 = new Node(data);
            newNode1 = head;
            head = newNode1;
            Console.WriteLine("{0} is added" + newNode1.data);
        }
    }

    internal void InsertBetween(int previous, int data, int after)
    {
        Node temp = head;
        Node newNode = new Node(data);
        Node store;
        while (temp != null)
        {
            if (temp.data == previous && temp.next.data == after)
            {
                store = temp.next;
                temp.next.next = newNode;
                newNode = store;
            }
            else
            {
                temp = (Node)temp.next;
            }
        }
    }
}

    















