using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Search works only for sorted arrays!!!
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int elem = 4;
            Console.WriteLine($"Element {elem} is found at positia: {BinarySearch(arr, elem)}");

            int[] arr2 = { 4,2,6,8,3,9,1 };
            //If the searched element doesn't exist in array, the method will return -1;
            Console.WriteLine(BinarySearch(arr2, 1)); //Will return -1. The array isn't sorted

        }
        public static int BinarySearch(int[] arr, int elem)
        {
            int firstIndex = 0;
            int lastIndex = arr.Length - 1;
            while(firstIndex <= lastIndex)
            {
                int middleIndex = (firstIndex + lastIndex) / 2;
                if (elem < arr[middleIndex])
                {
                    lastIndex = middleIndex - 1;
                }
                else if (elem > arr[middleIndex])
                {
                    firstIndex = middleIndex + 1;
                }
                else return middleIndex;
            }
            return -1;
        }
    }
}
