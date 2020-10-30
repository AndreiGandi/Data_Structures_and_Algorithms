using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        //n! = 1 * 2 * 3 * ... * n
        //0! = 1
        static void Main(string[] args)
        {
            int nr = 5; //120
            //Console.WriteLine($"{nr}! = {Factorial(nr)}");
            Console.WriteLine($"{nr}! = {RecursiveFactorial(nr)}");
        }

        //Iterative method
        static long Factorial(int nr)
        {
            long Fact = 1;
            for(int i = 2; i<=nr; i++)
            {
                Fact *= i;
            }
            return Fact;
        }

        //Recursive method
        static long RecursiveFactorial(int nr)
        {
            if (nr == 0) return 1;
            else return nr * RecursiveFactorial(nr - 1);
        }

        //static BigInteger RecursiveFactorial(int nr)
        //{
        //    if (nr == 0) return 1;
        //    else return nr * RecursiveFactorial(nr - 1);
        //}
    }
}
