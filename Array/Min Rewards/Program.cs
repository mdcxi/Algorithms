using System;

public class Program {
    public static int MinRewards(int[] scores) {
        // Write your code here.
        int lastMaxIndex = 0; //index of the last "peak" value
        //(values on either side are less than the value at this index)
        int lastMaxReward = 1; //Amount of the reward already given to the student at lastMaxIndex
        int previousReward = 1; //Amount of the reward already given to the student at i-1
        int totalRewards = 1; //Accumulator (running sum: tong hien co) of the total rewards
        
        /*
         * above values are initialized to the values 
         * they should be after examining node i = 0
        */
        
        //Iterate through the rest of the scores array (starting at node i = 1)
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > scores[i - 1])
            {
                //if node i > node i-1, the reward at node i is the reward at node i-1, plus 1
                totalRewards += ++previousReward;
                lastMaxIndex = i;
                lastMaxReward = previousReward;
            }
            else
            {
                //scores[i] < scores[i-1]
                //if node i < node i-1, then set the reward at node i to 1
                //if reward at node i-1 is also 1
                if (previousReward == 1)
                {
                    //then we also adjust the values of all
                    //previous rewards up to the last peak, by incrementing them by 1 each.
                    totalRewards += i - lastMaxIndex;
                    
                    //only increment the reward of the last peak if the reward of the node
                    //directly after the last peak will be equal to the reward of the last peak
                    if (i - lastMaxIndex >= lastMaxReward) totalRewards++;
                }
                else totalRewards += 1;

                previousReward = 1;
            }
        }
        
        return totalRewards;
    }
}