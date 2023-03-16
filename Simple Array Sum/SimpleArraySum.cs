using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    public class Result
    {
        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            foreach(var num in ar){
                sum += num;
            }
            return sum;
        }    
    }
}