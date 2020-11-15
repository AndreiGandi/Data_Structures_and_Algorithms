using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
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

            int[] sortedArr = SelectionSort(arr);
            foreach (var item in sortedArr)
            {
                Console.Write(item + " ");
            }
        }

        private static int[] SelectionSort(int[] arr)
        {
            for(int i = 0; i<arr.Length-1; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
            return arr;
        }
    }
}
