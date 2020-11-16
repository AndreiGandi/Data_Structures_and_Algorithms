using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6_Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareOfSum(100) - SumOfSquares(100));
        }
        public static long SumOfSquares(int limit)
        {
            long Sum = 0;
            for(int i=1; i<=limit; i++)
            {
                Sum += i * i;
            }
            return Sum;
        }
        public static long SquareOfSum(int limit)
        {
            long Sum = 0;
            Sum = limit * (limit + 1) / 2;

            return Sum * Sum;
        }

    }
}
