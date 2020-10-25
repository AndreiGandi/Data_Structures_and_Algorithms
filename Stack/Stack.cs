using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private int size; // Maximum Stack's size
        private string[] stackArray;
        private int top; //index of stack's last element

        public Stack(int size)
        {
            this.size = size;
            stackArray = new string[size];
            top = -1;
        }

        public void Push(string element)
        {
            if(isFull())
            {
                Console.WriteLine("The Stack is Full.");
            }
            else
            {
                top++;
                stackArray[top] = element;
            }
        }
        public string Pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("The Stack is Empty");
                return "--";
            }
            else
            {
                int old_top = top;
                top--;
                //stackArray[old_top] = "Empty Slot";
                return stackArray[old_top];
            }

        }

        public string Peek()
        {
            return stackArray[top];
        }

        public void DisplayStack()
        {
            for(int i = stackArray.Length-1; i>=0; i--)
            {
                if(stackArray[i] != null)
                Console.WriteLine("["+stackArray[i]+"]");
                else Console.WriteLine("[Empty Slot]");

            }
            Console.WriteLine();
        }

        public bool isEmpty()
        {
            return top == -1;
        }

        public bool isFull()
        {
            return (top == size - 1);
        }


    }
}
