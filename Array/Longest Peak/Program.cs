using System;

public class Program {
	public static int LongestPeak(int[] array) {
		// Write your code here.
		if (array.Length <= 2)
			return 0;
		
		int increment = 0; //incrementing count
		int decrement = 0; //decrementing count
		int max = 0; //Max found

		for (int i = 1; i < array.Length; i++)
		{
			int value = array[i];
			int previousValue = array[i - 1];

			if (value == previousValue)
			{
				increment = 0;
				decrement = 0;
				continue;
			}

			if (value > previousValue) //Incrementing
			{
				if (decrement > 0) //It was decrementing
				{
					increment = 0;
				}

				decrement = 0;
				increment++;
				continue;
			}

			if (value < previousValue && increment > 0) //Decrementing
			{
				decrement++;
				max = Math.Max(max, increment + decrement + 1);
			}
		}
		return max;
	}
}
