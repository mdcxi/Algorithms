using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Program {
    public static List<List<int> > MaxSumIncreasingSubsequence(int[] array) {
        // Write your code here.
        int[] sequences = new int[array.Length];
        Array.Fill(sequences, Int32.MinValue);
        int[] sums = (int[])array.Clone();
        int maxSumIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int currentNumber = array[i];
            for (int j = 0; j < i; j++)
            {
                int anotherNumber = array[j];
                if (anotherNumber < currentNumber && (sums[j] + currentNumber) >= sums[i])
                {
                    sums[i] = sums[j] + currentNumber;
                    sequences[i] = j;
                }
            }

            if (sums[i] >= sums[maxSumIndex])
            {
                maxSumIndex = i;
            }
        }

        return BuildSequence(array, sequences, maxSumIndex, sums[maxSumIndex]);
    }

    public static List<List<int>> BuildSequence(int[] array, int[] sequences,
        int currentIndex, int sums)
    {
        List<List<int>> sequence = new List<List<int>>();
        sequence.Add(new List<int>());
        sequence.Add(new List<int>());
        sequence[0].Add(sums);
        while (currentIndex != Int32.MinValue)
        {
            sequence[1].Insert(0, array[currentIndex]);
            currentIndex = sequences[currentIndex];
        }

        return sequence;
    }
}

