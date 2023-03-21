using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicsShop
{
    public class Result
    {
            static int getMoneySpent(int[] keyboards, int[] drives, int b) {

            int max = 0;
            int sum = 0;  

            foreach (var key in keyboards){
                foreach (var drive in drives){
                    sum = drive + key;
                    if (sum <= b  && max < sum )
                        max = sum;
                }
            }
            if (max > 0)
                return max;
            return -1;
        }
    }
}