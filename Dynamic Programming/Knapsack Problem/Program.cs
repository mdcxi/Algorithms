using System;
using System.Collections.Generic;

public class Program {
    public static List<List<int> > KnapsackProblem(int[,] items, int capacity) {
        // Write your code here.
        int[,] knapsackValue = new int[items.GetLength(0) + 1, capacity + 1];
        for (int i = 1; i < items.GetLength(0) + 1; i++)
        {
            int currentWeight = items[i - 1, 1];
            int currentValue = items[i - 1, 0];
            for (int j = 0; j < capacity + 1; j++)
            {
                if (currentWeight > j)
                {
                    knapsackValue[i, j] = knapsackValue[i - 1, j];
                }
                else
                {
                    knapsackValue[i, j] = Math.Max(knapsackValue[i - 1, j],
                        knapsackValue[i - 1, j - currentWeight] + currentValue);
                }
            }
        }

        return GetKnapsackItems(knapsackValue, items, knapsackValue[items.GetLength(0), capacity]);
    }

    public static List<List<int>> GetKnapsackItems(int[,] knapsackValues, int[,] items, int weight)
    {
        List<List<int>> sequence = new List<List<int>>();
        List<int> totalWeight = new List<int>();
        totalWeight.Add(weight);
        sequence.Add(totalWeight);
        sequence.Add(new List<int>());
        int i = knapsackValues.GetLength(0) - 1;
        int j = knapsackValues.GetLength(1) - 1;
        while (i > 0)
        {
            if (knapsackValues[i, j] == knapsackValues[i - 1, j])
            {
                i--;
            }
            else
            {
                sequence[1].Insert(0,i-1);
                j -= items[i - 1, 1];
                i--;
            }
            if(j == 0) break;
            
        }

        return sequence;
    }
}