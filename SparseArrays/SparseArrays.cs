using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparseArrays
{
    public class Result
    {
        public static List<int> matchingStrings(List<string> stringList, List<string> queries)
        {
            List<int> returnList = new List<int>();
            int iter = 0;
            
            foreach (var query in queries)
            {
                int numberOfQuery = stringList.Count(str => str == query);
                returnList.Insert(iter, numberOfQuery);
                iter++;
            }
            return returnList;
        }
    }
}