using System;

class SortedSquareArray
{
    public int[] sortedSquareArray(int[] array)
    {
        int[] newArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i] * array[i];
        }
        Array.Sort(newArray);
        return newArray;
    }
}