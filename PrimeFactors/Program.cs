using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Factors(8);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
        public static long[] Factors(long number)
        {
            List<long> factors = new List<long>();
            int div = 2;
            while (number > 1)
            {
                
                if(isPrime(div))
                {
                    if(number % div == 0)
                    {
                        factors.Add(div);
                        number /= div;
                    }
                    else
                    {
                        div++;
                    }
                }
                else
                {
                    div++;
                }
            }
            return factors.ToArray();
        }
        public static bool isPrime(long nr)
        {
            if (nr <= 1) return false;
            if (nr != 2 && nr % 2 == 0) return false;
            for(int i=2; i<nr/2; i++)
            {
                if (nr % i == 0) return false;
            }
            return true;

        }
    }
}
