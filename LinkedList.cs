using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        }
    }
    







    

