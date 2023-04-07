using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesByMatch
{
    public class Result
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            int pair = 0;
            
            for (int i = 0; i < ar.Count() - 1; i++)
            {
                for (int j = i + 1; j < ar.Count(); j++)
                {
                    if (ar[i] == ar[j])
                    {
                        pair++;
                        ar[i] *= -1;
                        ar[j] *= -1;
                    }    
                }
            }
            
            return pair;
        }
    }
}