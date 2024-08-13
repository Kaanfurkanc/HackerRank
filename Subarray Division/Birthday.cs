using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Subarray Division
{
    public class Birthday
    {

        public static int birthday(List<int> s, int d, int m)
        {
            int numberOfWays = 0;

            for (int i = 0; i < s.Count -m + 1; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    int num = s[i + j];
                    sum += num;
                    if (sum > d)
                        break;
                    else if (sum == d && j == m - 1)
                        numberOfWays++;
                }
            }
            
            return numberOfWays;
        }
    }
}