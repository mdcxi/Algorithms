using System;

public class Program {

    public int MaximizeExpression(int[] array) {
        // Write your code here.
        if (array.Length < 4) return 0;
        int[] maxValues = new int[]
        {
            Int32.MinValue, Int32.MinValue,
            Int32.MinValue, Int32.MinValue
        };
        for (int i = 0; i < array.Length; i++)
        {
            if (i > 2) //best ABCD: choose old (A-B+C-D) or (old A-B+C - array[i])
            {
                if (maxValues[2] - array[i] > maxValues[3])
                {
                    maxValues[3] = maxValues[2] - array[i];
                }
            }

            if (i > 1 && array.Length - i > 1) //best ABC: choose old (A-B+C) or (old A-B + array[i])
            {
                if (maxValues[1] + array[i] > maxValues[2])
                {
                    maxValues[2] = maxValues[1] + array[i];
                }
            }

            if (i > 0 && array.Length - i > 2) //best AB: choose old (A-B) or (old A - array[i])
            {
                if (maxValues[0] - array[i] > maxValues[1])
                {
                    maxValues[1] = maxValues[0] - array[i];
                }
            }

            if (array.Length - i > 3) // best A: choose old A or array[i]
            {
                if (array[i] > maxValues[0])
                {
                    maxValues[0] = array[i];
                }
            }
        }
        return maxValues[3];
    }
}