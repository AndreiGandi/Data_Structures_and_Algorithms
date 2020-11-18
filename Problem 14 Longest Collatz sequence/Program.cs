using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14_Longest_Collatz_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limit = 1000000;

            long max = 0;
            long number = 0;
            long sequence;

            for (int i = 2; i <= limit; i++)
            {
                int length = 1;
                sequence = i;
                while (sequence != 1)
                {
                    if ((sequence % 2) == 0)
                    {
                        sequence = sequence / 2;
                    }
                    else
                    {
                        sequence = sequence * 3 + 1;
                    }
                    length++;
                }
                if (length > max)
                {
                    max = length;
                    number = i;
                }
            }
            Console.WriteLine(number);
        }
        //public static int Collatz(int nr)
        //{
        //    int steps = 1;
        //    while(nr!=1)
        //    {
        //        if (nr % 2 == 0) nr /= 2;
        //        else nr = 3 * nr + 1;
        //        steps++;
        //    }
        //    return steps;
        //}
    }
}
