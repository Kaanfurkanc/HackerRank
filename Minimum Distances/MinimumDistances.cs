using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimumDistances
{
    public class Result
    {
        public static int minimumDistances(List<int> a)
        {
            int distance = 0;
            int temp = 0;
            List<int> lst = new List<int>();

            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[i] == a[j])
                    {
                        temp = j - i;
                        if (temp < 0)
                            temp *= -1;
                        lst.Add(temp);
                    }
                }
            }
            if (temp == 0)
                return -1;
            lst.Sort();
            distance = lst[0];
            return distance;
        }
    }
}