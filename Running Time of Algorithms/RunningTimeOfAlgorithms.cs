using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTimeOfAlgorithms
{
    public class Result
    {
        public static int runningTime(List<int> arr)
        {
            
            int shifts = 0;
            int temp = 0;
            int j = 0;
            
            for (int i = 1; i < arr.Count; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (temp < arr[j])
                {
                    arr[j +1] = arr[j];
                    arr[j] = temp;
                    j--;
                    shifts++;
                    if (j < 0)
                        break; 
                }
            }
            return shifts;
        }
    }
}