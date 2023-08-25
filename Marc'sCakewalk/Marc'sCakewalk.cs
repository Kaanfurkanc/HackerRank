using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcsCakewalk
{
    public class Result
    {
        public static long marcsCakewalk(List<int> calorie)
        {
            long miles = 0;
            long power = 1;

            // for getting minimum miles
            calorie.Sort(); 
            calorie.Reverse();
            
            for (int i = 0; i < calorie.Count; i++)
            {
                miles += power * calorie[i];
                power <<= 1; // power of two
            }
            
            return miles;
        }
    }
}