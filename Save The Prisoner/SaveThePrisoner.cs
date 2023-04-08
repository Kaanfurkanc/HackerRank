using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveThePrisoner
{
    public class Result
    {
        public static int saveThePrisoner(int n, int m, int s)
        {    
            var remain = m % n;
            
            if ((remain + s - 1) % n == 0)
                return n;
            else 
                return ((remain + s - 1) % n);         
            
            // The following code is exceed the time limit .
            // for (;m > 1;m--)
            // {
            //     if (s == n)
            //     {
            //         s = 1;
            //         continue;
            //     }
            //     s++;
            // }
            // return s;
        }
    }
}