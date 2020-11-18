using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16_Power_digit_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger nr = new BigInteger(Math.Pow(2, 1000));
            Console.WriteLine(nr.ToString());

            Console.WriteLine($"Digits Sum: {DigitsSum(nr.ToString())}");
        }
        static int DigitsSum(string nr)
        {
            int Sum = 0;
            while (nr.Length != 0)
            {
                Sum += int.Parse(nr[0].ToString());
                nr = nr.Substring(1);
            }



            return Sum;
        }

    }
}
