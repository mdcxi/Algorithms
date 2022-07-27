using System;
using System.Collections.Generic;

public class Program
{
    public static List<int> ZigzagTraverse(List<List<int>> array)
    {
        // Write your code here.
        int height = array.Count - 1;
        int width = array[0].Count - 1;
        int row = 0, col = 0;
        List<int> output = new List<int>();
        bool goingDown = true;

        while (!isOutOfBounds(row, col, height, width)) {
            output.Add(array[row][col]);
            if (goingDown) {
                if (col == 0 || row == height) {
                    goingDown = false;
                    if (row == height) {
                        col++;
                    }
                    else {
                        row++;
                    }
                }
                else {
                    row++;
                    col--;
                }
            }
            else
            {
                if (row == 0 || col == width) {
                    goingDown = true;
                    if (col == width) {
                        row++;
                    }
                    else {
                        col++;
                    }
                }
                else {
                    row--;
                    col++;
                }
            }
        }

        return output;
    }

    public static bool isOutOfBounds(int row, int col, int height, int width)
    {
        return row < 0 || row > height || col < 0 || col > width;
    }
}
