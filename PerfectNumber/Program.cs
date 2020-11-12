using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IsPerfect(28));
        }
        public static bool IsPerfect(int nr)
        {
            int Sum = 0;
            for(int i = 1; i<=nr/2; i++)
            {
                if (nr % i == 0) Sum += i;
            }
            return (Sum == nr);
        }
    }
}
