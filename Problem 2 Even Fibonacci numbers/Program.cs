using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limit = 4000000;
            int secondToLast = 0;
            int last = 1;
            int Fibo = 1;
            long Sum = 0;
            while(Fibo<limit)
            {
                Fibo = secondToLast + last;
                if (Fibo % 2 == 0) Sum += Fibo;
                secondToLast = last;
                last = Fibo;

            }
            Console.Write(Sum);
        }
    }
}
