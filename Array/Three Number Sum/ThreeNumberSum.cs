using System;
using System.Collections.Generic;

public class ThereNumberSum 
{
    public static List<int[]> FindThreeNumberSum (int[] array, int targetSum) {
        //E.x: array = [1, 2, 3 ,4, 5, 6, 7, 8, 9, 15] => Length = 9
        //targetSum = 32
        Array.Sort(array);
        List <int[]> tripletArray = new List<int[]>();

        for (int i = 0; i < array.Length - 2; i++)
        {
            int left = i + 1; 
            int right = array.Length - 1; 

            while (left < right)
            {
                int currentSum = array[i] + array[left] + array[right];
                if (currentSum == targetSum)
                {
                    int[] newTripletArray = { array[i], array[left], array[right] };
                    tripletArray.Add(newTripletArray);
                    left++;
                    right--;
                }
                else if (currentSum < targetSum)
                {
                    left++; 
                }
                else if (currentSum > targetSum)
                {
                    right--;
                }
            }
        }
        return tripletArray;
    }
}