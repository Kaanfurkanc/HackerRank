using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheTimeInWords
{
    public class Result
    {
        public static readonly Dictionary<int, string> numbers = new Dictionary<int, string>
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" },
            { 10, "ten" },
            { 11, "eleven" },
            { 12, "twelve" },
            { 13, "thirteen" },
            { 14, "fourteen" },
            { 15, "fifteen" },
            { 16, "sixteen" },
            { 17, "seventeen" },
            { 18, "eighteen" },
            { 19, "nineteen" },
            { 20, "twenty" },
            { 21, "twenty one" },
            { 22, "twenty two" },
            { 23, "twenty three" },
            { 24, "twenty four" },
            { 25, "twenty five" },
            { 26, "twenty six" },
            { 27, "twenty seven" },
            { 28, "twenty eight" },
            { 29, "twenty nine" }
        };
        
        public static string timeInWords(int h, int m)
        {
            string time = "";
            string hour = numbers[h];
            string minute = "";
            
            if (m == 0)
            {
                time = hour + " o' clock";
                return time;
            }
            else if (m >= 1 && m <= 30)
            {
                if (m == 15)
                {
                    time = "quarter past " + hour;
                    return time;
                }
                else if (m == 30)
                {
                    time = "half past " + hour;
                    return time;
                }
                else 
                {
                    minute = numbers[m];
                    if (m == 1)
                        time = minute + " minute past " + hour;
                    else
                        time = minute + " minutes past " + hour;
                    return time;
                }
            }
            else
            {
                if (m == 45)
                {
                    hour = numbers[h + 1];
                    time = "quarter to " + hour;
                }
                else
                {
                    minute = numbers[60 - m];
                    hour = numbers[h + 1];
                    time = minute + " minutes to " + hour;
                }
                return time;
            }
            return new string("");
        }
    }
}