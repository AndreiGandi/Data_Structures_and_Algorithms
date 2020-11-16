using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            for(int i=999; i>=100; i--)
            {
                for(int j=i; j>=100; j--)
                {
                    if (isPalindrom(i * j))
                    {
                        if (i * j > max)
                            max = i * j;

                    }
                }
            }
            Console.WriteLine(max);
        }
        public static bool isPalindrom(int nr)
        {
            string sNr = nr.ToString();
            char[] charsnr = sNr.ToCharArray();
            Array.Reverse(charsnr);
            if(sNr == new string(charsnr))
                return true;
            return false;
        }
    }
}
