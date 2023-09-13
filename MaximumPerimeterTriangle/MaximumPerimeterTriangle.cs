using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaximumPerimeterTriangle
{
    public class Result
    {
        public static List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            sticks.Sort();
            List<int> biggestTriangle = new List<int>();
            int size = sticks.Count;
            
            for (int i = size - 1; i >= 2; i--)
            {
                if (sticks[i - 2] + sticks[i - 1] > sticks[i])
                {
                    biggestTriangle.Add(sticks[i - 2]);
                    biggestTriangle.Add(sticks[i - 1]);
                    biggestTriangle.Add(sticks[i]);
                    return biggestTriangle;
                }    
            }
            biggestTriangle.Add(-1);
            return biggestTriangle;
        }
    }
}