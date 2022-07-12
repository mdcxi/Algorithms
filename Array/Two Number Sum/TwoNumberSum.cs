using System;
using System.Collections.Generic;

public class TwoNumberSum
{
    public static int[] CalculateTwoNumberSum(int[] array, int targetSum)
    {
        var hashSet = new HashSet<int>();
        
        for (int i = 0; i < array.Length; i++)
        {
            int value = targetSum - array[i];
            if (hashSet.Contains(value))
            {
                Console.WriteLine("[{0}, {1}]",array[i],value);
            }

            hashSet.Add(array[i]);
        }

        return new int[0];
    }

    public static void Main()
    {
        int[] array = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int targetSum = 3;
        CalculateTwoNumberSum(array,targetSum);
    }
}