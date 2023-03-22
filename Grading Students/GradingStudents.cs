using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradingStudents
{
    public class Result
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            int remainder = 0;
            
            for (int i= 0; i < grades.Count(); i++){
                
                remainder = grades[i] % 5;
                
                if (5 - remainder  == 3  && grades[i] >= 40)
                    continue;
                else if (5 - remainder > 3  && grades[i] >= 40)
                    continue;
                else if (5 - remainder < 3  && grades[i] >= 38)
                    grades[i] = grades[i] + 5 - remainder;
            }
            
            return grades;    
        }
    }
}