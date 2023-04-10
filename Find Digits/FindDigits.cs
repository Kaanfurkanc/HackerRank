using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindDigits
{
    public class Result
    {
        public static int findDigits(int n)
        {
            int digit = 0;
            int temp = n;
            
            while (temp > 0)
            {
                var d = temp % 10;
                if ((d != 0) && (n % d == 0))
                    digit++;
                    
                temp = temp / 10;
            }
            return digit;
        }
    }
}