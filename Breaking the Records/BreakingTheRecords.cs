using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakingTheRecords
{
    public class Result
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            int lowest = scores[0];
            int highest = scores[0];
            int highRecord = 0;
            int lowRecord = 0;
            
            foreach (int score in scores)
            {
                if ( score > highest)
                {
                    highest = score;
                    highRecord++;
                }
                else if (score < lowest)
                {
                    lowest = score;
                    lowRecord++;
                }
            }
            return new List<int>{highRecord,lowRecord};
        }
    }
}