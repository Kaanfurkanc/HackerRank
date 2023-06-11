using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsertionSortPart2
{
    public class InsertionSortPart2
    {
        public static void insertionSort2(int n, List<int> arr)
        {
            int temp = 0;
            int j = 0;
            
            for (int i = 1; i < n; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    arr[j] = temp;

                    j--;
                    if (j < 0)
                        break;
                }
                arr.ForEach(item => Console.Write(item + " "));
                Console.WriteLine();
            }
        }
    }
}