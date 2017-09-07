using Apttus.Stack;
using System;
using System.Collections.Generic;

namespace Apttus.Stack_Generic
{
    public class StackOperation
    {
        private static void Main(string[] args)
        {
            int capacity;
            Console.WriteLine("Enter Capacity of Stack :");
            capacity = int.Parse(Console.ReadLine());

            IStack<string> stack = new MyStack<string>(10);

            while (true)
            {
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Print Stack Elements:");

                Console.WriteLine("Enter your Choice :");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter item to be pushed :");
                            string temp = Console.ReadLine();
                            int result = stack.push(temp);

                            if (result != -1)
                            {
                                Console.WriteLine("Element Pushed into Stack !");
                            }
                            else
                            {
                                Console.WriteLine("Stack Overflow !");
                            }
                            break;
                        }
                    case 2:
                        {
                            string Result = stack.pop();
                            if (Result != null)
                            {
                                Console.WriteLine("Delete Element :" + Result);
                            }
                            else
                            {
                                Console.WriteLine("Stack Underflow !");
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("***************Item in the stack are******************");

                            stack.Display();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("You have Entered Wrong Choice ");
                            break;
                        }

                        
                }
                Console.WriteLine("************************************");
            }
        }
    }
}