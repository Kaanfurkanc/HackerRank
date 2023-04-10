using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ExtraLongFactorials
{
    public class Result
    {
        public static void extraLongFactorials(int n)
        {
            BigInteger result = 1;
            
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}