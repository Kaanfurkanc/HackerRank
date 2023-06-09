using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsExploration
{
    public class Result
    {
        public static int marsExploration(string s)
        {
            int falseMessageNumber = 0;
            int index = 0;
            string trueMessage = "SOS";
            int i = 0;
            
            while (index < s.Length)
            {
                if (trueMessage[i] != s[index])
                    falseMessageNumber++;
                if (i == 2)
                    i = -1;
                i++;
                index++; 
            }
            return falseMessageNumber;
        }
    }
}