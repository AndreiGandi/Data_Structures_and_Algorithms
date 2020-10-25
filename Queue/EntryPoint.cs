using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Queue Person = new Queue(5);
            Person.Insert("Andrei");
            Person.Insert("John");
            Person.Insert("Marry");
            Person.Insert("Jack");
            Person.Insert("Ivan");

            //Person.DisplayQueue();

            //Person.Insert("Roberto"); //the Queue is Full
            Console.WriteLine(Person.PeekFront());
            Person.Remove();

            Person.DisplayQueue();


        }
    }
}
