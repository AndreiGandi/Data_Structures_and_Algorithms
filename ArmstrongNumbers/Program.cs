using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumbers
{
    class Program
    {
        //An Armstrong number is a number that is the sum of its own digits each raised to the power of the number of digits.

        //    9 is an Armstrong number, because 9 = 9^1 = 9
        //    10 is not an Armstrong number, because 10 != 1^2 + 0^2 = 1
        //    153 is an Armstrong number, because: 153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
        //    154 is not an Armstrong number, because: 154 != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190

        static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrongNumber(154));
        }
        public static bool IsArmstrongNumber(int number)
        {
            int pow = number.ToString().Length;
            int sum = 0;
            int temp = number;
            while(temp != 0)
            {
                sum += (int)Math.Pow(temp % 10, pow);
                temp /= 10;
            }
            if (sum == number)
                return true;
            return false;
        }
    }
}
