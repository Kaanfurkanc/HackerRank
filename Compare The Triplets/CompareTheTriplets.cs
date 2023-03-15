using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    public class Result
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();
            result.Add(0);
            result.Add(0);
            for(int i = 0; i <=2;i++){
                int j = 0;
                if (a[i] > b[i]) {
                    result[0]+=1;
                }
                else if (a[i]<b[i]){
                    result[1]+=1;
                }
                j++;
            }
            return result;
        }  
    }
}