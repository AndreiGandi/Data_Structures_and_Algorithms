using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] result = Slices("35", 2); // {35}
            //string[] result = Slices("9142", 2); // { "91", "14", "42" }
            //string[] result = Slices("777777", 3); // { "777", "777", "777", "777" }
            string[] result = Slices("918493904243", 5); // { "91849", "18493", "84939", "49390", "93904", "39042", "90424", "04243" }
        }
        //public static string[] Slices(string numbers, int sliceLength)
        //{
        //    if (numbers.Length == 0 || sliceLength <= 0 || numbers.Length < sliceLength) throw new ArgumentException();
        //    List<string> series = new List<string>();
        //    for(int i=0; i<numbers.Length-(sliceLength-1); i++)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        for(int j = i; j<i+sliceLength; j++)
        //        {
        //            sb.Append(numbers[j]);
        //        }
        //        series.Add(sb.ToString());
        //    }

        //    return series.ToArray();


        //}
        public static string[] Slices(string numbers, int sliceLength)
        {
            if (sliceLength > numbers.Length || sliceLength < 1)
            {
                throw new ArgumentException();
            }

            List<string> series = new List<string>();

            for (int i = 0; i <= (numbers.Length - sliceLength); i++)
            {
                string newSeries = numbers.Substring(i, sliceLength);
                series.Add(newSeries);
            }

            return series.ToArray();
        }
    }
}
