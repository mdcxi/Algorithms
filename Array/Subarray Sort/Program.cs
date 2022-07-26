using System;

public class Program {
    public static int[] SubarraySort(int[] array) {
        // Write your code here.
        int minOutOfOrder = Int32.MaxValue;
        int maxOutOfOrder = Int32.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            int num = array[i];
            if (isOutOfOrder(i, num, array))
            {
                minOutOfOrder = Math.Min(minOutOfOrder, num);
                maxOutOfOrder = Math.Max(maxOutOfOrder, num);
            }
        }

        if (minOutOfOrder == Int32.MaxValue) return new int[] { -1, -1 }; 

        int left = 0;
        while (minOutOfOrder >= array[left]) { left++; }

        int right = array.Length - 1;
        while (maxOutOfOrder <= array[right]) { right--; }
        
        return new int[] {left, right};
    }

    public static bool isOutOfOrder(int i, int num, int[] array)
    {
        if (i == 0) return num > array[i + 1];
        if (i == array.Length - 1) return num < array[i - 1];
        return num > array[i + 1] || num < array[i - 1];
    }
}