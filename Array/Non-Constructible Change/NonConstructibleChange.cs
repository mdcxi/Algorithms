using System;

public class Program {

    public int NonConstructibleChange(int[] coins) {
        // Write your code here.
        // coins = [1,2,3,4,5,6,7]
        //if i add a new coin value = 8, i can create a change = 8
        //but if i add a new coin value = 9, i can't create a change = 8  because 7+1 < 9 
        //so the minimum change is = 8
        int change = 0;
        Array.Sort(coins);

        for (int i = 0; i <  coins.Length; i++)
        {
            if ((change + 1) >= coins[i])
            {
                change += coins[i];
                continue;
            }
            else
                break;
        }
        return change + 1;
    }
}
