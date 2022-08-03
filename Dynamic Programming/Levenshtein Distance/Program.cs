using System;

public class Program {
    public static int LevenshteinDistance(string str1, string str2) {
        // Write your code here.
        int[,] array = new int[str2.Length + 1, str1.Length + 1];
        
        for (int i = 0; i < str2.Length + 1; i++)
        {
            for (int j = 0; j < str1.Length + 1; j++)
            {
                array[i, j] = j;
            }

            array[i, 0] = i;
        }

        for (int i = 1; i < str2.Length + 1; i++)
        {
            for (int j = 1; j < str1.Length + 1; j++)
            {
                if (str2[i - 1] == str1[j - 1])
                {
                    array[i, j] = array[i - 1, j - 1];
                }
                else
                {
                    array[i, j] = 1 + Math.Min(
                        array[i - 1, j - 1],
                        Math.Min(array[i - 1, j], array[i, j - 1])
                    );
                }
            }
        }

        return array[str2.Length, str1.Length];
    } 
}