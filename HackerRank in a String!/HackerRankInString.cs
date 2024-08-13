using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRankinaString
{
    public class Result
    {
        public static string hackerrankInString(string s)
        {
            const string str = "hackerrank";
            string result = "YES";
            int prevIndex = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                int index = s.IndexOf(str[i], prevIndex);
                if(index == -1)
                {
                    result = "NO";
                    break;
                }
                if (index < prevIndex)
                {
                    result = "NO";
                    break;
                }
                prevIndex = index + 1;
            }
            return result;
        }
    }
}