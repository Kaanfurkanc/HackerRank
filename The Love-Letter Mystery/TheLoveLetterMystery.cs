using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheLoveLetterMystery
{
    public class Result
    {
        public static int theLoveLetterMystery(string s)
        {
            int len = s.Count();
            int counter = 0;
            
            for (int i = 0; i < len; i++)
            {
                if (s[i] > s[len - 1])
                    counter += s[i] - s[len - 1];
                else if (s[i] < s[len - 1])
                    counter += s[len - 1] - s[i]; 
                
                len--;
            }
            return counter;
        } 
    }
}