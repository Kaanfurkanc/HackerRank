using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppendAndDelete
{
    public class Result
    {
        public static string appendAndDelete(string s, string t, int k)
        {
            int counter = 0; 
            int sindex = 0;
            int tindex = 0;
            int i = 0;
            
            if (s == t)
                return "Yes";
            else
            {
                while (sindex < s.Count() && tindex < t.Count())
                {
                    if (s[i] == t[i])
                        i++;
                    sindex++;
                    tindex++;
                }
                counter += s.Count() - i;
                counter += t.Count() - i;
                
                if (counter > k)
                    return "No";
            }
            return "Yes";
        }
    }
}