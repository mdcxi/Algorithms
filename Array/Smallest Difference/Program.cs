using System;

public class Program {
    public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo) {
        // Write your code here.
        Array.Sort(arrayOne);
        Array.Sort(arrayTwo);
        int idxOne = 0, idxTwo = 0;
        int smallest = Int32.MaxValue;
        int current = Int32.MaxValue;
        int[] smallestPair = new int[2];

        while (idxOne < arrayOne.Length
               && idxTwo < arrayTwo.Length) {
            int firstNum = arrayOne[idxOne];
            int secondNum = arrayTwo[idxTwo];
            
            if (firstNum < secondNum) {
                current = secondNum - firstNum;
                idxOne++;
            }
            else if (firstNum > secondNum)
            {
                current = firstNum - secondNum;
                idxTwo++;
            }
            else {
                return new int[] { firstNum, secondNum };
            }

            if (smallest > current)
            {
                smallest = current;
                smallestPair = new int[] { firstNum, secondNum };
            }
        }
        return smallestPair;
    }
}
