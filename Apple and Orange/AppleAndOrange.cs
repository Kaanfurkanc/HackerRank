using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    public class Result
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int numberOfApple = 0;
            int numberOfOrange = 0;
            
            foreach(var item in apples){
                if (a + item >= s && a + item <= t)
                    numberOfApple++;
            }
            foreach(var item in oranges){
                if (b + item >= s && b + item <= t)
                    numberOfOrange++;
            }
            Console.WriteLine(numberOfApple);
            Console.WriteLine(numberOfOrange);
        }
    }
}