using System;

public class Program {

	public int NumberOfWaysToTraverseGraph(int width, int height) {
		// Write your code here.
		if (width == 1 || height == 1)
			return 1;
		return NumberOfWaysToTraverseGraph(width-1,height) 
		       + NumberOfWaysToTraverseGraph(width,height - 1);
	}
}
