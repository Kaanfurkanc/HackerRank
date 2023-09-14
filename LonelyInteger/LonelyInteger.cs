using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LonelyInteger
{
    public class Result
    {
        public static int lonelyinteger(List<int> a)
        {
            a.Sort();
            int size = a.Count;
            
            for (short i = 0; i < a.Count - 1; i++)
            {
                if (a[i] != a[i + 1])
                {
                    return a[i];
                }
                i++;
            }
            return a[size - 1];
        }
    }
}