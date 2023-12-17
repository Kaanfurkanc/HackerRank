using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoStrings
{
    public class Result
    {
        public static string twoStrings(string s1, string s2)
        {
            foreach (var char1 in s1)
            {
                if (s2.Contains(char1))
                    return "YES";
            }
            return "NO";
        }
    }
}