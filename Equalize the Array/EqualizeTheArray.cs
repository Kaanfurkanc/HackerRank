using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqualizeTheArray
{
    public class Result
    {
        public static int equalizeArray(List<int> arr)
        {
            int counter = 1;
            int max = 0;

            arr.Sort();

            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                    counter++;

                else
                {
                    if (max < counter)
                        max = counter;
                    counter = 1;
                }
            }
            if (counter > max)
                max = counter;
            return (arr.Count - max);
        }
    }
}