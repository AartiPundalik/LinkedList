using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            
                Console.WriteLine("Welcome to the Linked List");
                Console.WriteLine("Enter a program number given below");
                Console.WriteLine("1:- Linked List\n" + "2:- Custom Linked Listed\n" + "3:- Linked List U 3\n" + "4:- Insert Node\n");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        LinkedList num = new LinkedList();
                        num.Addlast(56);
                        num.Addlast(30);
                        num.Addlast(70);
                        num.Display();
                        break;

                    case 2:
                        LinkedList customLL = new LinkedList();
                        customLL.Addlast(70);
                        customLL.Addlast(30);
                        customLL.Addlast(56);
                        customLL.Display();
                        break;

                    case 3:
                    LinkedList num2 = new LinkedList();
                    num2.AddAtfirst(56);
                    num2.Addlast(30);
                    num2.Addlast(70);
                    num2.Display();
                    break;

                case 4:
                    LinkedList num3 = new LinkedList();
                    num3.Addlast(70);
                    num3.AddAtfirst(56);
                    num3.Display();
                    num3.InsertBetween(56, 30, 70);
                    num3.Display();
                    break;

            }


            Console.ReadLine();
            }
        }
    }


    








        

