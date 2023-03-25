using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillDivision
{
    public class Result
    {
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int sum = 0;
            int give = 0;
            
            for (int i = 0; i < bill.Count(); i++)
            {
                if (i == k)
                    continue;  
                sum += bill[i];
            }
            
            if (sum / 2 == b)
                Console.WriteLine("Bon Appetit"); 
            else
            {
                give = bill[k] / 2;
                Console.WriteLine(give);
            }
        }
    }
}