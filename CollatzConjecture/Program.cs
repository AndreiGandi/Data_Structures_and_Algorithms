using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Steps(1)); // return 0;
            Console.WriteLine(Steps(16)); // return 4;
            Console.WriteLine(Steps(12)); // return 9;
            Console.WriteLine(Steps(1000000)); // return 152;
        }
        public static int Steps(int number)
        {
            if (number <= 0) throw new ArgumentOutOfRangeException();
            int steps = 0;
            while (number != 1)
            {
                if (number % 2 == 0)
                {
                    number /= 2; steps++;
                }
                else
                {
                    number = number * 3 + 1;
                    steps++;
                }


            }
            return steps;
        }
    }
}
