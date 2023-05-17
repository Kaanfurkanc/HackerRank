using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HalloweenSale
{
    public class Result
    {
        public static int howManyGames(int p, int d, int m, int s)
        {
        // Return the number of games you can buy
            int numberOfGame = 0;
            int total = 0;
                
            while (p >= m)
            {
                total += p;
                if (total <= s)
                {
                    numberOfGame++;
                } 
                p -= d;
            }
            total += m;
            while (total <= s)
            {
                numberOfGame++;
                total += m;
            }
            return numberOfGame;
        }
    }
}