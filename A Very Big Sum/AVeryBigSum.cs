using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A Very Big Sum
{
    public class Result
    {
        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach(long num in ar){
                sum += num;
            }
            return sum;
        }
    }
}