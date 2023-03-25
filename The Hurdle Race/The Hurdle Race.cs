using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheHurdleRace
{
    public class Result
    {
        public static int hurdleRace(int k, List<int> height)
        {
            int maxH = 0;
            
            foreach (int h in height)
            {
                if (maxH < h)
                    maxH = h;
            }
            if (maxH > k)
                return maxH - k;
            
            return 0;
        }
    }
}