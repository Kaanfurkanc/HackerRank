using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  PlusMinus
{
    public class Result
    {
        public static void plusMinus(List<int> arr)
        {
            float pos = 0;
            float neg = 0;
            float zero = 0;
            
            foreach (var item in arr)
            {
                if (item < 0 )
                    neg++;
                else if(item > 0)
                    pos++;
                else
                    zero++;
            }
            Console.WriteLine($"{pos / arr.Count()}\n{neg / arr.Count()}\n{zero / arr.Count()}");
        }
    }
}