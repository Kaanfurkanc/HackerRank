using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreedyFlorist
{
    public class Result
    {
        static int getMinimumCost(int k, int[] c) 
        {
            int cost = 0;
            int multiply = 1;
            Array.Sort(c);
            
            for (int i = c.Length -1; i >= 0; i--)
            {
                for (int j = 0; j < k; j++)
                {
                    if (i == 0)
                    {
                        cost += (c[i] * multiply);
                        break;
                    }
                    else if (i - j >= 0)
                        cost += (c[i - j] * multiply);
                }
                multiply++;
                i = i - k + 1;
            }
            return cost;
        }
    }
}