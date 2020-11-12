using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTableGrains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Total());
        }
        public static ulong Square(int n)
        {
            if (n <= 0 || n > 64) throw new ArgumentOutOfRangeException();
            ulong grains = 1;
            for (ulong i = 2; i <= (ulong)n; i++)
            {
                grains *= 2;
            }
            return grains;
        }


        //For total amount of grains
        public static ulong Total()
        {
            return (ulong)Math.Pow(2, 64) - 1;

        }
    }
}
