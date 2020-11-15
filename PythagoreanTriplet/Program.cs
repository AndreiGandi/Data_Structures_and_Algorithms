using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTriplet
{
    class Program
    {
        //Given an input integer N, find all Pythagorean triplets for which a + b + c = N.
        //For example, with N = 1000, there is exactly one Pythagorean triplet for which a + b + c = 1000: {200, 375, 425}.

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for(int a = 1; a<=N/2; a++)
            {
                for(int b = a + 1; b<N/2; b++)
                {
                    int c = (int)Math.Sqrt( a * a + b * b );
                    double cc = Math.Sqrt(a * a + b * b);

                    if(c == cc && (a+b+c == N))
                        Console.WriteLine($"[{a}, {b}, {c}]");
                }
            }
        }
    }
}
