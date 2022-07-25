using System;
using System.Collections.Generic;

public class Program {
    public static List<int> SpiralTraverse(int[,] array) {
        // Write your code here.
        if (array.GetLength((0)) == 0)
            return new List<int>();
        
        var result = new List<int>();
        var firstRow = 0;
        var lastRow = array.GetLength(0) - 1;
        var firstColumn = 0;
        var lastColumn = array.GetLength(1) - 1;

        while (firstColumn <= lastColumn && firstRow <= lastRow)
        {
            for (int column = firstColumn; column <= lastColumn; column++)
            {
                result.Add(array[firstRow, column]);
            }

            for (int row = firstRow + 1; row <= lastRow; row++)
            {
                result.Add(array[row, lastColumn]);
            }

            for (int column = lastColumn - 1; column >= firstColumn; column--)
            {
                if (firstRow == lastRow) break;
                result.Add((array[lastRow, column]));
            }
            
            for (int row = lastRow- 1; row > firstRow; row--)
            {
                if (firstColumn == lastColumn) break;
                result.Add((array[row, firstColumn]));
            }

            firstRow++;
            lastRow--;
            firstColumn++;
            lastColumn--;
        }
        return result;
    }
}