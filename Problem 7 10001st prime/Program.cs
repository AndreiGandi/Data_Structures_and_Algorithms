using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7_10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 2; ; i++)
            {
                if(isPrime(i))
                {
                    count++;
                }
                if(count == 10001)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        static bool isPrime(int nr)
        {
            if (nr <= 1) return false;
            else if (nr % 2 == 0 && nr != 2) return false;
            else
            {
                for(int i= 2; i<=nr/2; i++)
                {
                    if (nr % i == 0) return false;
                }
            }
            return true;
            
                        
        }
    }
}
