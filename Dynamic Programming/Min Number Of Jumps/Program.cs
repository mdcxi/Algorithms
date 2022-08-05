using System;

public class Program {
    public static int MinNumberOfJumps(int[] array) {
        // Write your code here.
        int left = 0, right = 0, minJump = 0;
        while (right < array.Length - 1)
        {
            int furthest = 0;
            for (int i = left; i < right + 1; i++)
            {
                furthest = Math.Max(array[i] + i, furthest);
            }

            left = right + 1;
            right = furthest;
            minJump += 1;
        }
    
        return minJump;
    }
}