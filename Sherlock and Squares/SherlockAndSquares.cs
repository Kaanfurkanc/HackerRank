using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SherlockAndSquares
{
    public class Result
    {
        public static int squares(int a, int b)
        {
            var lowBound = Math.Ceiling(Math.Sqrt(a));
            var highBound = Math.Floor(Math.Sqrt(b));
            
            return (Convert.ToInt32(highBound - lowBound +1));
        }
    }
}