using System;

public class Program
{
    //O(1)
    public static bool IsMonotonic(int[] array)
    {
        // Write your code here.
        var isIncreasing = false;
        var isDecreasing = false;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] > array[i]) 
                isDecreasing = true;
            if (array[i - 1] < array[i]) 
               isIncreasing = true;
            if (isDecreasing && isIncreasing)
                return false;
        }

        return true;
    }
}
