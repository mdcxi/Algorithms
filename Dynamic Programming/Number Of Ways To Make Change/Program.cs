using System;

public class Program {
    public static int NumberOfWaysToMakeChange(int n, int[] denoms) {
        // Write your code here.
        int[] ways = new int[n + 1];
        ways[0] = 1;
        foreach (int denomination in denoms)
        {
            for (int amount = 1; amount < n + 1; amount++)
            {
                if (denomination <= amount)
                {
                    ways[amount] += ways[amount - denomination];
                }
            }
        }
        return ways[n];
    }
}