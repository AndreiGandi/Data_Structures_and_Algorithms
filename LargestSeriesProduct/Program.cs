using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace LargestSeriesProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine(GetLargestProduct("0123456789", 2)); //72
            //Console.WriteLine(GetLargestProduct("0123456789", 3)); //504
            //Console.WriteLine(GetLargestProduct("1027839564", 3)); //270
            //Console.WriteLine(GetLargestProduct("0123456789", 5)); //15120
            //Console.WriteLine(GetLargestProduct("73167176531330624919225119674426574742355349194934", 6)); //23520
            //Console.WriteLine(GetLargestProduct("0000", 2)); //0
            //Console.WriteLine(GetLargestProduct("99099", 3)); //0
            //Console.WriteLine(GetLargestProduct("", 0)); //1
            //Console.WriteLine(GetLargestProduct("123", 0)); //1
            ////Console.WriteLine(GetLargestProduct("", 1)); // ArgumentException
            ////Console.WriteLine(GetLargestProduct("123", 4)); // ArgumentException
            ////Console.WriteLine(GetLargestProduct("1234a5", 2)); // ArgumentException
            //Console.WriteLine(GetLargestProduct("12345", -1)); //ArgumentException

        }

        public static long GetLargestProduct(string digits, int span)
        {
            if (span > digits.Length) throw new ArgumentException();
            if (digits.Length == 0) return 1;
            if (span == 0) return 1;
            if (span < 0) throw new ArgumentException();

            //Case "1234a5" : Check string to contains only digits
            if (!Regex.IsMatch(digits, @"^[0-9]+$"))
                throw new ArgumentException();


            long maxProduct = 0;
            for(int i = 0; i<=digits.Length-span; i++)
            {
                long product = 1;
                for(int j = i; j<i+span; j++)
                {
                    product *= int.Parse(digits[j].ToString());
                }
                if (product > maxProduct)
                    maxProduct = product;
            }
                

            return maxProduct;
            
        }
        public static BigInteger GetLargestProduct_BigInteger(string digits, int span)
        {
            if (span > digits.Length) throw new ArgumentException();
            if (digits.Length == 0) return 1;
            if (span == 0) return 1;
            if (span < 0) throw new ArgumentException();

            //Case "1234a5" : Check string to contains only digits
            if (!Regex.IsMatch(digits, @"^[0-9]+$"))
                throw new ArgumentException();


            BigInteger maxProduct = new BigInteger();
            for (int i = 0; i <= digits.Length - span; i++)
            {
                BigInteger product = new BigInteger(1);
                for (int j = i; j < i + span; j++)
                {
                    product *= int.Parse(digits[j].ToString());
                }
                Console.WriteLine(product);
                if (product > maxProduct)
                    maxProduct = product;
            }


            return maxProduct;

        }
    }
}
