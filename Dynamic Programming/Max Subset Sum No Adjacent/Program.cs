using System;

public class Program {
	public static int MaxSubsetSumNoAdjacent(int[] array) {
		// Write your code here.
		if (array.Length == 0) return 0;
		if (array.Length == 1) return array[0];
		if (array.Length == 2) return Math.Max(array[0], array[1]);
		
		int[] maxSums = new int[3];
		maxSums[0] = array[0];
		maxSums[1] = Math.Max(array[0], array[1]);

		for (int i = 2; i < array.Length; i++)
		{
			maxSums[2] = Math.Max(array[i] + maxSums[0], maxSums[1]);
			maxSums[0] = maxSums[1];
			maxSums[1] = maxSums[2];
		}
		return maxSums[1];
	}
}
