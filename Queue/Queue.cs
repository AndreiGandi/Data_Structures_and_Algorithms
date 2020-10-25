using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        private int size; //Queue's maximum size
        private string[] people; //myQueue
        private int front; // First element index
        private int rear; // Last element index
        private int items; // nr of elements in queue;

        public Queue(int size)
        {
            this.size = size;
            people = new string[size];
            front = 0;
            rear = -1;
            items = 0;
        }

        public void Insert(string elem) //Enqueue
        {
            if(isFull())
            {
                Console.WriteLine("The Queue is Full");
            }
            else
            {
                rear++;
                people[rear] = elem;
                items++;
            }

        }

        public bool isFull()
        {
            return (items == size);
        }
         
        public string Remove() //Dequeue
        {
            if(isEmpty())
            {
                Console.WriteLine("The Queue is Empty");
                return "";
            }
            else
            {
                string temp = people[front];
                front++;
                return temp;
            }
        }

        public string PeekFront()
        {
            return people[front];
        }

        public bool isEmpty()
        {
            return (items == 0);
        }

        public void DisplayQueue()
        {
            for(int i = 0; i<people.Length; i++)
            {
                Console.WriteLine($"[{people[i]}]");
            }
            Console.WriteLine();
        }
    }

}
