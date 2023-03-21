using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountingValleys
{
    public class Result
    {
        public static int countingValleys(int steps, string path)
        {   
            int counter = 0;
            int level = 0;

            foreach (var item in path){
                if (item == 'U'){
                    if (level == -1)
                        counter++;
                    level++;
                }
                if (item == 'D')
                    level--;         
            }
            return counter;
        }
    }
}