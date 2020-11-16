using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            for(int i=3; i<1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    Sum += i;
            }
            Console.WriteLine(Sum);
        }
    }
}
