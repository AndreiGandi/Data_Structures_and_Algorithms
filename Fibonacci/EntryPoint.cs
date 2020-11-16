using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class EntryPoint
    {
        //Fibonacci : 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
        static void Main(string[] args)
        {
            int nr = 10;
            Console.WriteLine($"Firsts {nr} elements of Fibonacci's serie\n");
            Console.WriteLine("*************************Iterative methods*************************");
            Console.WriteLine(Fibonacci(nr));
            Console.WriteLine("*************************Recursive methods*************************");
            Console.WriteLine(RecursiveFibonacci(nr));
        }

        //Iterative method
        static string Fibonacci(int n)
        {
            long last = 1;
            long secondToLast = 0;
            long Fibo = 0;
            string sFibo = "0 1 ";
            for(int i = 3; i<=n; i++)
            {
                Fibo = secondToLast + last;
                secondToLast = last;
                last = Fibo;
                sFibo += Fibo.ToString()+" ";
            }
            return sFibo;
        }

        //Recursive method
        static long RecursiveFibonacci(int n)
        {
            if (n <= 3) return 1;
            else return RecursiveFibonacci(n-1) + RecursiveFibonacci(n - 2);
        }
    }
}
