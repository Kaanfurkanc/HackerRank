using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangrams
{
    public class Result
    {
        public static string pangrams(string s)
        {
            List<int> differences = new List<int>();
            foreach (char c in s)
            {
                int diff = char.ToLower(c) - 96;
                if (!differences.Contains(diff) && char.IsLetter(c))
                {
                    differences.Add(diff);
                }
            }
            differences.Sort();
            
            //There are 26 letters in english alphabet.
            if (differences.Count == 26 && differences[0] == 1 && differences[25] == 26)
                return "pangram";
            else
                return "not pangram";
        }
    }
}