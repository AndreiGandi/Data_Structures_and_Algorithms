using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10_Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int limit = 2000000;
            long  sum = 0;
            //for(int i = 2; i<= limit; i++)
            //{
            //    if (isPrime(i))
            //    {
            //        Console.WriteLine($"{i}");
            //        sum += i;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
            //    }
            //}

            bool[] primesArray = GeneratePrimes(limit);
            for(int i=0; i<=limit; i++)
            {
                if (primesArray[i] == false)
                    sum += i;
            }
            Console.WriteLine(sum);
        }

        //Check every number -> extremly inefficient. Check implementation using Sieve of Eratosthenes
        //static bool isPrime(int nr)
        //{
        //    if (nr <= 1) return false;
        //    else if (nr % 2 == 0 && nr != 2) return false;
        //    else
        //    {
        //        for (int i = 2; i <= nr / 2; i++)
        //        {
        //            if (nr % i == 0) return false;
        //        }
        //    }
        //    return true;


        //}
        static bool[] GeneratePrimes(int max)
        {
            bool[] sieve = new bool[max + 1];
            sieve[0] = sieve[1] = true;
            for (int i = 2; i <= max; i++)
            {
                if (!sieve[i])
                {
                    for (int j = 2 * i; j <= max; j += i)
                    {
                        sieve[j] = true;
                    }
                }
            }
            return sieve;
        }
    }
}
