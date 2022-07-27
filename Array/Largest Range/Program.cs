using System;
using System.Collections.Generic;
public class Program {
    public static int[] LargestRange(int[] array) {
        // Write your code here.
        //Input: [0,1,2,5,6,7,8,9,10]
        //There are 2 ranges: [0,1,2] and [5,6,7,8,9,10]
        //Output: [5,10]
        HashSet<int> numbers = new HashSet<int>();
        
        //dumb all numbers in HashSet for O(1) lookup
        foreach (int number in array) { numbers.Add(number); }

        int[] result = new int[2];
        int maxRange = 0;
        for (int i = 0; i < array.Length; i++) {
            //only if the next number is not present
            if (!numbers.Contains(array[i] + 1)) {
                int endRange = array[i];
                int lowRange = array[i];
                //we consider the current as highest end range and start drilling down
                //until there is something not found
                while (numbers.Contains((--lowRange))) ;
                lowRange += 1;
                //just increase by +1 as its the number not found and we don't consider it
                //done...Just update the result with the best answer
                if (maxRange < (endRange - lowRange) + 1) {
                    result[0] = lowRange;
                    result[1] = endRange;
                    maxRange = (endRange - lowRange) + 1;
                }
            }
        }
        return result;
    }
}