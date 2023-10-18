using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SequenceEquation
{
    public class SequenceEquation
    {
        public static List<int> permutationEquation(List<int> p)
        {
            int min = p.Min();
            int max = p.Max();
            int index = 0;
            int index2 = 0;
            
            var result = new List<int>();
            
            while (min <= max)
            {
                index = p.IndexOf(min) + 1;
                index2 = p.IndexOf(index) + 1;
                result.Add(index2);
                min++;   
            }
            return result;
        }
    }
}