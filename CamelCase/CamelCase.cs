using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CamelCase
{
    public class Result
    {
        public static int camelcase(string s)
        {
            int result = 1;

            foreach (var letter in s)
            {
                if (letter >= 65 && letter <= 90)
                    result++;
            }

            return result;
        }
    }
}