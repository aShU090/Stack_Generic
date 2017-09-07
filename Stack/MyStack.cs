using System;
using System.Collections.Generic;

namespace Apttus.Stack
{
    public class MyStack<T> : IStack<T>
    {
        private List<T[]> li = new List<T[]>();
        private int capacity;
        private T[] stack;
        private int top;

        public MyStack(int MaxElements)
        {
            capacity = MaxElements;
            stack = new T[capacity];
        }

        public int push(T Element)
        {
            //checking for Overflow
            if (top == capacity - 1)
            {
                // return -1 if over flow is there
                return -1;
            }
            else
            {
                // Push element into stack
                top = top + 1;
                stack[top] = Element;
            }
            return 0;
        }

        public T pop()
        {
            T Removed;

            //checking for Underflow
            if (!(top <= 0))
            {
                Removed = stack[top];
                top = top - 1;
                return Removed;
            }
            return default(T);
        }

        public void Display()
        {
            if (top != 0)
            {
                for (int i = top; i > 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
            else
            {
                Console.WriteLine("no element in stack,it is empty");
            }
        }

       
    }
}