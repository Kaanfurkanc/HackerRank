using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeftRotation
{
    public class Result
    {
        public static List<int> rotateLeft(int d, List<int> arr)
        {
            int temp = 0;
            
            while (d > 0)
            {
                temp = arr[0];
                arr.RemoveAt(0);
                arr.Add(temp);
                d--;
            }
            return arr;
        }
    }
}