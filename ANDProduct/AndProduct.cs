using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANDProduct
{
    public class Result
    {
        public static long andProduct(long a, long b)
        {
            long result = (a & (a + 1));
            a++;
            
            for(int i = 0; a <= b; a += 2^i)
            {
                result = a & result;
                i++;
            }
                    
            return result;
        }
    }
}