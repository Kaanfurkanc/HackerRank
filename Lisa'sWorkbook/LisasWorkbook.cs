using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lisa'sWorkbook
{
    public class Result
    {
        public static int workbook(int n, int k, List<int> arr)
        {
            int numberOfSpecialProblems = 0;
            int pageNumber = 1;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (j == pageNumber)
                        numberOfSpecialProblems++;
                    if (j % k == 0 && j != arr[i])
                        pageNumber++;
                }
                pageNumber++;   
            }
            return numberOfSpecialProblems;
        }
    }
}