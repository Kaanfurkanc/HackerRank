using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DivisibleSomePairs
{
    public class Result
    {
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int counter = 0;
            
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        counter++;
                }
            }
            return counter;
        }   
    }
}