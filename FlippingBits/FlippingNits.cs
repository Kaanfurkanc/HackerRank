using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlippingBits
{
    public class Result
    {
        public static long flippingBits(long n)
        {
            double max =  Math.Pow(2, 32) - 1; // Max unsigned int value
            long result = (long)max - n;
        
            return result;
        }
    }
}