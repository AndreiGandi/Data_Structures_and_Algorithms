using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Stack
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Stack cars = new Stack(10);
            cars.Push("Volvo");
            cars.Push("BMW");
            cars.Push("Citroen");
            cars.Push("Mercedes");
            cars.Push("Jeep");

            cars.DisplayStack();

            Console.WriteLine(cars.Peek());

            cars.Pop();

            cars.DisplayStack();
            Console.WriteLine(cars.Peek());




        }
    }
}
