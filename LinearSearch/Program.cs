using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // the algorithm is very inefficient for large amounts of data
            int[] arr = { 1, 5, 2, 4, 8, 9, 12, 33, 456, 123, 22, 19 };
            int search = 19;
            Console.WriteLine($"{search} is located at index {LinearSearch(arr, search)}");
        }
        public static int LinearSearch(int[] arr, int elem)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i] == elem) return i;
            }
            return -1;
        }
    }
}
