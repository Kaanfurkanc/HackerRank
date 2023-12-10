using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMaximumSubarray
{
    public class Result
    {
        public static List<int> maxSubarray(List<int> arr)
        {
            int length = arr.Count;
            var subList = new List<int>();
            var maxSumAnd = new int[length];
            int sumOfSubarray = 0;
            int sumOfSubsequence = 0;

            
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0)
                    sumOfSubsequence += arr[i];
            }
            
            maxSumAnd[0] = arr[0];
            for (int i = 1; i < length; i++)
            {
                if (maxSumAnd[i - 1] > 0)
                    maxSumAnd[i] = arr[i] + maxSumAnd[i - 1];
                else
                    maxSumAnd[i] = arr[i];
            }
            
            sumOfSubarray = maxSumAnd.Max();
            if (sumOfSubsequence == 0)
                sumOfSubsequence = arr.Max();

            subList.Add(sumOfSubarray);
            subList.Add(sumOfSubsequence);
            return subList;
        }
    }
}