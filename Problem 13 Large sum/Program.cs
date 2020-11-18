using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13_Large_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"D:\Programming\Data_Structures_and_Algorithms\Problem 13 Large sum\Numbers.txt");
            
            BigInteger Sum = new BigInteger();
            foreach(var item in text)
            {
                BigInteger currentNumber = BigInteger.Parse(item);
                Sum += currentNumber;
            }
            string s = Sum.ToString().Substring(0,10);
            Console.WriteLine(s);

        }
    }
}
