using System;


namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            //on every year that is evenly divisible by 4
            //except every year that is evenly divisible by 100
            //unless the year is also evenly divisible by 400
            Console.WriteLine(Leap(1900));
        }
        public static bool Leap(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                return true;
            return false;
        }
    }
}
