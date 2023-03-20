using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    public class Result{
        public static int birthdayCakeCandles(List<int> candles)
        {
            int tallest = candles.Max();
            int counter = 0;
            
            foreach(var item in candles){
                if(item == tallest)
                    counter++;
            }
            return counter;
        }
    }
}