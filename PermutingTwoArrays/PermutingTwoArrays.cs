using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermutingTwoArrays
{
    public class Result
    {
        public static string twoArrays(int k, List<int> A, List<int> B)
        {
            const string yes = "YES";
            const string no = "NO";
            int length = A.Count;

            A.Sort();
            var descB = B.OrderByDescending(num => num).ToList();

            for (int i = 0; i < length; i++)
            {
                if (A[i] + descB[i] < k)
                    return no;
            }
            return yes;
        }
    }
}