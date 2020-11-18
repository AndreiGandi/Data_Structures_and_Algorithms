using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_20_Factorial_digit_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string sFactorial = Factorial(100).ToString() ;
            Console.WriteLine($"Sum of digits for 100!: {DigitsSum(sFactorial)}");
            
        }
        static BigInteger Factorial(int nr)
        {
            BigInteger Fact = 1;
            for(int i=1; i<=nr; i++)
            {
                Fact *= i;
            }
            return Fact;
        }
        static int DigitsSum(string nr)
        {
            int Sum = 0;
            while(nr.Length != 0)
            {
                Sum += int.Parse(nr[0].ToString());
                nr = nr.Substring(1);
            }



            return Sum;
        }
    }
}
