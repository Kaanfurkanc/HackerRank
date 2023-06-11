using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingSort1
{
    public class Result
    {
        public static List<int> countingSort(List<int> arr)
        {
            int[] numbers = new int[100];
            int numberOfItem = 0;
            
            for (int i = 0; i < 100; i++)
            {
                numberOfItem = arr.Count(x => x == i);
                numbers[i] = numberOfItem;
            }
            
            return numbers.ToList();
        }
    }
}