using System;
using System.Collections.Generic;

public class Program {
    public static List<int[]> DiskStacking(List<int[]> disks) {
        // Write your code here.
        disks.Sort((disks1, disks2) => disks1[2].CompareTo(disks2[2]));
        int[] heights = new int[disks.Count];
        for (int i = 0; i < disks.Count; i++)
        {
            heights[i] = disks[i][2];
        }

        int[] sequences = new int[disks.Count];
        for (int i = 0; i < disks.Count; i++)
        {
            sequences[i]=Int32.MinValue;
        }

        int maxHeightIndex = 0;
        for (int i = 1; i < disks.Count; i++)
        {
            int[] currentDisk = disks[i];
            for (int j = 0; j < i; j++)
            {
                int[] anotherDisk = disks[j];
                if (areValidDimensions(currentDisk, anotherDisk))
                {
                    if (heights[i] <= currentDisk[2] + heights[j])
                    {
                        heights[i] = currentDisk[2] + heights[j];
                        sequences[i] = j;
                    }
                }
            }

            if (heights[i] >= heights[maxHeightIndex])
            {
                maxHeightIndex = i;
            }
        }
        
        return BuildSequence(disks,sequences,maxHeightIndex);
    }
    
    public static bool areValidDimensions(int[] i, int[] j)
    {
        return i[0] < j[0] && i[1] < j[1] && i[2] < j[2];
    }

    public static List<int[]> BuildSequence(List<int[]> array, int[] sequences, int currentIndex)
    {
        List<int[]> sequence = new List<int[]>();
        while (currentIndex != Int32.MinValue)
        {
            sequence.Insert(0, array[currentIndex]);
            currentIndex = sequences[currentIndex];
        }

        return sequence;
    }
}