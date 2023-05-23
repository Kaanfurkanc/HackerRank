using System;

public class InsertionSortPart1
{
	public class Result()
	{
		public static void insertionSort1(int n, List<int> arr)
        {
            int temp = arr[n - 1];

            // 2 4 6 8 3

            for (int i = n - 1; i > 0; i--)
            {
                if (arr[i - 1] > temp)
                {
                    arr[i] = arr[i - 1];
                    arr.ForEach(item => Console.Write(item + " "));
                    if (i == 1)
                    {
                        arr[i - 1] = temp;
                        Console.WriteLine();
                        arr.ForEach(item => Console.Write(item + " "));
                    }
                }

                else
                {
                    arr[i] = temp;
                    arr.ForEach(item => Console.Write(item + " "));
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
