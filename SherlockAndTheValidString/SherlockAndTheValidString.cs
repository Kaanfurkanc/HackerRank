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
            const string validResult = "YES";
            const string invalidResult = "NO";
            int numberOfTime = 0;
            int before = 0;
            short counter = 0;
            List<char> distinctList = new List<char>();
            

            distinctList = s.Distinct().ToList();
            before = s.Count(c => c == distinctList[0]);
            for (int i = 1; i < distinctList.Count; i++)
            {
                numberOfTime = s.Count(c => c == distinctList[i]);
                if (numberOfTime == before)
                    continue;
                var diff = before - numberOfTime;
                if (diff > 1 || diff < -1)
                {
                    if (numberOfTime == 1)
                    {
                        counter++;
                        if (counter > 1)
                            return invalidResult;
                    }
                    else
                        return invalidResult;
                }
                else if (diff == 1 || diff == -1)
                {
                    counter++;
                    if (counter > 1)
                        return invalidResult;
                }
            }
            return validResult;
        }
    }
}