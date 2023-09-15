using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViralAdvertising
{
    public class Result
    {
        public static int viralAdvertising(int n)
        {
            int cumulative = 0;
            int day = 1;
            int shared = 5;
            
            while (day <= n)
            {
                cumulative += shared / 2;
                shared = (shared / 2) * 3;
                day++;
            }
            
            return cumulative;
        }
    }
}