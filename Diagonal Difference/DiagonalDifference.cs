using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    public class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftToRight = 0;
            int rightToLeft = 0;
            int len = arr.Count();
            
            for (int i = 0 ; i < len; i++){
                for (int j = 0; j <len ;j++){
                    if (j == len - i -1)
                        rightToLeft += arr[i][j];
                    if(j == i)
                        leftToRight += arr[i][j];
                }
            }
            return Math.Abs(rightToLeft - leftToRight);  
        }
    }
}