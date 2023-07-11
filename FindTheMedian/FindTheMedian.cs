using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindTheMedian
{
    public class Result
    {
        public static int findMedian(List<int> arr)
        {
            int median = 0;
            int size = arr.Count();

            arr.Sort();
            if (size % 2 == 0)
            {
                median = (arr[size / 2] + arr[(size / 2) - 1]);
            }
            else
                median = arr[size / 2];
            return median;
        }
    }
}