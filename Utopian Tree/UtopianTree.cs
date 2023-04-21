using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UtopianTree
{
    public class Result
    {
        public static int utopianTree(int n)
        {
            int height = 1;
            
            for (int i=1; i <= n; i++)
            {
                if (i % 2 != 0)
                    height *= 2;
                else
                    height++;
            }
            return height;
        }
    }
}