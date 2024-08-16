using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayOfTheProgrammer
{
    public class Result
    {
        public static string dayOfProgrammer(int year)
        {
            Dictionary<string, string> daysOfProgrammers = new Dictionary<string, string>
            {
                {"leap", $"12.09.{year}"},
                {"notLeap", $"13.09.{year}"},
                {"1918", $"26.09.{year}"}
            };
            
            if (year == 1918)
                return daysOfProgrammers["1918"];
            else if ((year < 1918 && year % 4 == 0) || (year > 1918 && ((year % 4 == 0  && year % 100 != 0) || year % 400 == 0)))
                return daysOfProgrammers["leap"];
            return daysOfProgrammers["notLeap"];
            
        }
    }
}