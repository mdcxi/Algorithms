using System;
using System.Collections.Generic;

public class Program {
    public static bool SameBsts(List<int> arrayOne, List<int> arrayTwo) {
        // Write your code here.
        if (arrayOne.Count != arrayTwo.Count) return false;
        if (arrayOne.Count == 0 && arrayTwo.Count == 0) return true;
        if (arrayOne[0] != arrayTwo[0]) return false;

        List<int> leftOne = GetSmaller(arrayOne);
        List<int> leftTwo = GetSmaller(arrayTwo);
        List<int> rightOne = GetBiggerOrEqual(arrayOne);
        List<int> rightTwo = GetBiggerOrEqual(arrayTwo);

        return SameBsts(leftOne,leftTwo) && SameBsts(rightOne,rightTwo);
    }
    
    public static List<int> GetSmaller(List<int> array)
    {
        List<int> smaller = new List<int>();

        for (int i = 1; i < array.Count; i++)
        {
            if(array[i] <array[0]) smaller.Add(array[i]);
        }

        return smaller;
    }

    public static List<int> GetBiggerOrEqual(List<int> array)
    {
        List<int> biggerOrEqual = new List<int>();

        for (int i = 1; i < array.Count; i++)
        {
            if(array[i] >= array[0]) biggerOrEqual.Add(array[i]);
        }

        return biggerOrEqual;
    }
}