using System.Collections.Generic;
using System;

public class Program {
    //O(n): where n is the length of the input array
    public int FirstDuplicateValue(int[] array) {
        // Write your code here.
        HashSet<int> newArray = new HashSet<int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (newArray.Contains(array[i]))
            {
                return array[i];
            }
            else
            {
                newArray.Add(array[i]);
            }
        }
        return -1;
    }
}