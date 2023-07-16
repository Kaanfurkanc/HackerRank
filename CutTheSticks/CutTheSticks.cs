using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CutTheSticks
{
    public class Result
    {
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int> elementsOfIterations = new List<int>();
            int size = arr.Count;
            arr.Sort();
            elementsOfIterations.Add(size);
            
            for (int i = 1; i < size; i++)
            {
                if (arr[i - 1] != arr[i])
                    elementsOfIterations.Add(size - i);
            }
            return elementsOfIterations;       
        }
    }
}