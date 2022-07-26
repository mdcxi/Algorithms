using System;

public class Program {
    //O(n^2) time complexity
    public int[] ArrayOfProducts(int[] array) {
        // Write your code here.
        int[] products = new int[array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            int product = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (i != j)
                {
                    product *= array[j];
                }

                products[i] = product;
            }
        }
        return products;
    }
}