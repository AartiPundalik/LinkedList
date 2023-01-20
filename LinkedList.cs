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

        internal void InsertBetween(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
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

    internal Node DeleteFirstNode(int data)
    {
        if (this.head == null)
        {
            return null;
        }
        this.head = this.head.next;
        Console.WriteLine("Element First{0} Is Removed", data);
        return this.head;
    }


    internal Node DeleteLastNode(int data)
    {
        if (this.head == null)
        {
            return null;
        }
        if (this.head.next == null)
        {
            return null;
        }
        Node temp = head;
        while (temp.next.next != null)
        {
            temp = temp.next;
        }
        temp.next = null;
        Console.WriteLine("Last Element {0} Is Removed", data);
        return this.head;
    }


    internal void Search(int data)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.data == data)
            {
                Console.WriteLine("The node {0} is found.", temp.data);
                return;
            }
            temp = temp.next;
        }
        if (temp == null)
        {
            Console.WriteLine("\nThe Node {0} is not found in the linked list.", data);
        }
    }


    internal void SearchNodeAddNode(int searchdata, int insertdata)
    {
        Node temp = head;
        Node newnode = new Node(insertdata);
        while (temp.data != searchdata)
        {
            temp = temp.next;
        }
        newnode.next = temp.next;
        temp.next = newnode;
        Console.WriteLine("{0} inserted afer the {1} node in the linked list", newnode.data, temp.data);
    }


 internal void SearchNodeDeleteNode(int SearchDeletedata)
{
    Node temp = head;
    Node newnode = new Node(SearchDeletedata);
    while (temp.next.data != newnode.data)
    {
        temp = temp.next;
    }
    temp.next = temp.next.next;

    Console.WriteLine("{0} deleted afer the {1} node in the linked list", SearchDeletedata, temp.data);
}
    }
}
























