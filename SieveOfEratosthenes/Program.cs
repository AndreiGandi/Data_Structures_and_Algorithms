using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] arr = Sieve_Optimized2(100);
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == false) Console.Write(i+" ");
            }
        }

        static bool[] Sieve(int max)
        {
            bool[] sieve = new bool[max+1];
            sieve[0] = sieve[1] = true;
            for(int i=2; i<= max; i++)
            {
                if(!sieve[i])
                {
                    for(int j = 2*i; j<= max; j+=i)
                    {
                        sieve[j] = true;
                    }
                }
            }
            return sieve;
        }

        static bool[] Sieve_Optimized1(int max)
        {
            bool[] sieve = new bool[max + 1];
            sieve[0] = sieve[1] = true;
            for (int i = 2; i*i <= max; i++)
            {
                if (!sieve[i])
                {
                    for (int j = i * i; j <= max; j += i)
                    {
                        sieve[j] = true;
                    }
                }
            }
            return sieve;
        }

        static bool[] Sieve_Optimized2(int max)
        {
            bool[] sieve = new bool[max + 1];
            sieve[0] = sieve[1] = true;
            for (int i = 4; i <= max; i += 2) //Eliminam toate numerele pari, mai mari decat 2
                sieve[i] = true;
            for(int i = 3; i*i<=max; i++)
            {
                if(!sieve[i])
                {
                    for (int j = i * i; j <= max; j += 2 * i)
                        sieve[j] = true;
                }
            }
            return sieve;
        }
    }
}
