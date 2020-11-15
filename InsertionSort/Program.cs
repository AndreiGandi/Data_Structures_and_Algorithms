using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9, 2, 1, 6, 7, 12, 27, 32, 15, 3, 19 };
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int[] sortedArr = InsertionSort(arr);
            foreach (var item in sortedArr)
            {
                Console.Write(item + " ");
            }
        }

        private static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; ++i)
            {
                int currentElement = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than currentElement, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > currentElement)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = currentElement;
            }
            return arr;
        }
    }
}
