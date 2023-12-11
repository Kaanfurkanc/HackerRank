using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringConstruction
{
    public class StringConstruction
    {
        public static int stringConstruction(string s)
        {
            int cost = 0;
            s.ToList();
            var distinctList = s.Distinct();
            cost = distinctList.Count();
            return cost;
        }
    }
}