using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    public class result
    {
        public static void miniMaxSum(List<int> arr)
        {
            long sumMin = 0;
            long sumMax = 0;
            
            arr.Sort();
            
            for(int i = 0;i <=3;i++){
                sumMin += arr[i];
                sumMax += arr[i+1];
            }
            Console.WriteLine($"{sumMin} {sumMax}");
        }
    }
}