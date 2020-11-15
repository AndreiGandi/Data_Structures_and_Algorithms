using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
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

            int[] sortedArr = BubbleSort(arr);
            foreach(var item in sortedArr)
            {
                Console.Write(item + " ");
            }
        }
        public static int[] BubbleSort(int[] arr)
        {
            bool sorted = false;
            while(!sorted)
            {
                sorted = true;
                for(int i = 0; i<arr.Length-1; i++)
                {
                    if(arr[i] > arr[i+1])
                    {
                        int aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                        sorted = false;
                    }
                }
            }
            return arr;
        }

    }
}
