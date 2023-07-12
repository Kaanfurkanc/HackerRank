using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace IceCreamParlor
{
    public class Result
    {
        public static List<int> icecreamParlor(int m, List<int> arr)
        {
            List<int> flavors = new List<int>();
            
            for (int i = 0; i < arr.Count() - 1; i++)
            {
                for (int j = 1; j < arr.Count(); j++)
                {
                    if (arr[i] + arr[j] == m && i != j)
                    {
                        flavors.Add(i + 1);
                        flavors.Add(j + 1);
                        return flavors;
                    }
                }
            }
            return flavors;
        }
    }
}