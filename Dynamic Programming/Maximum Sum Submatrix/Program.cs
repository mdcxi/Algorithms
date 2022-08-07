using System;

//O(W*H) time 
public class Program {

    public int MaximumSumSubmatrix(int[,] matrix, int size) {
        // Write your code here.
        int[,] sums = CreateSumSubmatrix(matrix);
        int matrixSubmatrixSum = Int32.MinValue;

        for (int row = size - 1; row < matrix.GetLength(0); row++)
        {
            for (int column = size - 1; column < matrix.GetLength(1); column++)
            {
                int total = sums[row, column];

                bool touchesTopBorder = (row - size < 0);
                if (!touchesTopBorder)
                {
                    total -= sums[row - size, column];
                }

                bool touchesLeftBorder = (column - size < 0);
                if (!touchesLeftBorder)
                {
                    total -= sums[row, column - size];
                }

                bool touchesTopOfLeftBorder = (touchesTopBorder || touchesLeftBorder);
                if (!touchesTopOfLeftBorder)
                {
                    total += sums[row - size, column - size];
                }

                matrixSubmatrixSum = Math.Max(matrixSubmatrixSum, total);
            }
        }
        return matrixSubmatrixSum;
    }

    public int[,] CreateSumSubmatrix(int[,] matrix)
    {
        int[,] sums = new int[matrix.GetLength(0), matrix.GetLength(1)];
        sums[0, 0] = matrix[0, 0];
        
        //Fill the first row
        for ( int i=1; i< matrix.GetLength(1); i++)
        {
            sums[0, i] = sums[0, i - 1] + matrix[0, i];
        }
        
        //Fill the first column
        for ( int i=1; i< matrix.GetLength(0); i++)
        {
            sums[i, 0] = sums[i - 1, 0] + matrix[i, 0];
        }
        
        //Fill in the rest of the matrix
        for (int row = 1; row < matrix.GetLength(0); row++)
        {
            for (int column = 1; column < matrix.GetLength(1); column++)
            {
                sums[row, column] = sums[row - 1, column] + sums[row, column - 1] - sums[row - 1, column - 1]
                                    + matrix[row, column];
            }
        }

        return sums;
    }
}