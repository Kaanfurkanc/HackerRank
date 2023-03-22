using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndMouse
{
    public class Result
    {
        static string catAndMouse(int x, int y, int z) {
            
            if (Math.Abs(x - z) > Math.Abs(y - z))
                return "Cat B";
            else if (Math.Abs(x - z) < Math.Abs(y - z))
                return "Cat A";
            else 
                return "Mouse C";
        }
    }
}