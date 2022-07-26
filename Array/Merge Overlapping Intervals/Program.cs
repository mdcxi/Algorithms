using System;
using System.Collections;
using System.Collections.Generic;


public class Program 
{
    //O(nlog(n)) time complexity
    public int[][] MergeOverlappingIntervals(int[][] intervals) 
    {
        //in case of one interval, no merges possible
        if (intervals.Length <= 1) return intervals;
        
        //sort the intervals by starting value
        int[][] sortedIntervals = intervals.Clone() as int[][];
        Array.Sort(sortedIntervals, (a,b) => a[0].CompareTo(b[0]));

        List<int[]> mergedIntervals = new List<int[]>();
        int[] currentInterval = sortedIntervals[0];
        mergedIntervals.Add(currentInterval);

        foreach (var nextInterval in sortedIntervals)
        {
            int currentIntervalEnd = currentInterval[1];
            int nextIntervalStart = nextInterval[0];
            int nextIntervalEnd = nextInterval[1];

            if (currentIntervalEnd >= nextIntervalStart)
            {
                currentInterval[1] = Math.Max(currentIntervalEnd, nextIntervalEnd);
            }
            else
            {
                currentInterval = nextInterval;
                mergedIntervals.Add(currentInterval);
            }
        }
        return mergedIntervals.ToArray();
    }
}