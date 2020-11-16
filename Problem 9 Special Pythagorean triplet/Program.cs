using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9_Special_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int a = 1; a <= N / 2; a++)
            {
                for (int b = a + 1; b < N / 2; b++)
                {
                    int c = (int)Math.Sqrt(a * a + b * b);
                    double cc = Math.Sqrt(a * a + b * b);

                    if (c == cc && (a + b + c == N))
                        Console.WriteLine($"[{a}, {b}, {c}] - > a x b x c = {a*b*c}");
                }
            }
        }
    }
}
