using System;

public class Program {
    public static int MinNumberOfCoinsForChange(int n, int[] denoms) {
        // Write your code here.
        int[] numberOfCoins = new int[n + 1];
        Array.Fill(numberOfCoins,Int32.MaxValue);
        numberOfCoins[0] = 0;
        int toCompare = 0;
        foreach (var denomination in denoms)
        {
            for (int amount = 0; amount < numberOfCoins.Length; amount++)
            {
                if (denomination <= amount)
                {
                    if (numberOfCoins[amount - denomination] == Int32.MaxValue)
                    {
                        toCompare = numberOfCoins[amount - denomination];
                    }
                    else
                    {
                        toCompare = numberOfCoins[amount - denomination] + 1;
                    }

                    numberOfCoins[amount] = Math.Min(numberOfCoins[amount], toCompare);
                }
            }
        }
        return numberOfCoins[n]!= Int32.MaxValue ? numberOfCoins[n] : -1;
    }
}