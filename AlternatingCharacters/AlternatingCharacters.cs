using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace AlternatingCharacters
{
    public class Result
    {
        public static int alternatingCharacters(string s)
        {
            int numberOfDeletions = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].Equals(s[i + 1]))
                {
                    // s.Remove(i + 1,1);
                    numberOfDeletions++;
                }
            }
            return numberOfDeletions;
        }
    }
}