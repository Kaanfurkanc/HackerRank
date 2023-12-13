using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SherlockAndTheValidString
{
    public class Result
    {
        public static string isValid(string s)
        {
            const string yes = "YES";
            const string no = "NO";
            int numberOfTime = 0;
            int before = 0;
            short counter = 0;
            List<char> distinctList = new List<char>();
            var list = s.ToList();
            
            distinctList = list.Distinct().ToList();
            before = list.Count(c => c == distinctList[0]);
            for (int i = 1; i < distinctList.Count; i++)
            {
                numberOfTime = list.Count(c => c == distinctList[i]);
                if (numberOfTime == before)
                    continue;
                var diff = before - numberOfTime;
                if (diff > 1 || diff < -1)
                    return no;
                else if (diff == 1 || diff == -1)
                {
                    counter++;
                    if (counter > 1)
                        return no;
                }
            }
            return yes;
        }
    }
}