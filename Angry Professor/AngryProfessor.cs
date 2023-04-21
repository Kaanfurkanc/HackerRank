using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngryProfessor
{
    public class Result
    {
        public static string angryProfessor(int k, List<int> a)
        {
            var result = "NO";
            int counter = 0;
            
            foreach(var item in a)
            {
                if (item <= 0)
                    counter++;
            }
            if (counter < k)
                result = "YES";
                
            return result;
        }
    }
}