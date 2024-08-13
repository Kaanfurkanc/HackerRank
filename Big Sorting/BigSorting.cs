using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigSorting
{
    public class Result
    {
        public static List<string> bigSorting(List<string> unsorted)
        {
            var sorted = unsorted?.OrderBy(a => a.Length).ThenBy(a => a).ToList();
            return sorted;

        }
    }
}