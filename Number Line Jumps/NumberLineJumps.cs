using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberLineJumps
{
    public class Result
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string answer = "NO";
            int x =  x2 - x1;
            
            if (v1 > v2 && x % (v1 - v2) == 0)
                answer = "YES";
            else
                answer = "NO";
            /*
            while (i < 10000 ){
                if (x1 + (v1 * i) == x2 + (v2*i))
                    answer = "YES";
                i++;
            }*/
            return answer;
        }     
    }
}