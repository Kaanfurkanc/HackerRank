using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace BeautifulBinaryString
{
    public class Result
    {
        public static int beautifulBinaryString(string b)
        {
            char[] arr = b.ToCharArray();
            int moves = 0;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i - 1] == '0' && arr[i] == '1' && arr[i + 1] == '0')
                {
                    moves++;
                    i += 2;
                }
            }
            return moves;
        }
    }
}