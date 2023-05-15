using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepeatedString
{
    public class Result
    {
        public static long repeatedString(string s, long n)
        {
            long result = 0;
            long size = s.Count();
            long numberOfA = 0;

            foreach (var item in s)
            {
                if (item == 'a')
                    numberOfA++;
            }

            result = numberOfA * (n / size);

            for (int i = 0; i < (n % size); i++)
            {
                if (s[i] == 'a')
                    result++;
            }
            return result;
        }
    }
}