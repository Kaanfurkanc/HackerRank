using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace FunnyString
{
    public class Result
    {
        public static string funnyString(string s)
        {
            string funny = "Funny";
            string notFunny = "Not Funny";
            char[] str = s.ToArray();
            char[] reverseS = str.Reverse().ToArray();
            List<int> difference = new List<int>();
            List<int> differenceReverse = new List<int>();

            for (int i = 0; i < str.Length - 1; i++)
            {
                difference.Add(Math.Abs(str[i] - str[i + 1]));
                differenceReverse.Add(Math.Abs(reverseS[i] - reverseS[i + 1]));
            }

            for (int i = 0; i < difference.Count; i++)
            {
                if (difference[i] != differenceReverse[i])
                    return notFunny;
            }
            return funny;
        }
    }
}