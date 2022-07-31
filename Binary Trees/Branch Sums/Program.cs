using System;
using System.Collections.Generic;

public class Program {
    // This is the class of the input root. Do not edit it.
    public class BinaryTree {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value) {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }

    public static List<int> BranchSums(BinaryTree root) {
        // Write your code here.
        int sum = 0;
        List<int> sumList = new List<int>();
        CalculateBrachSums(root,sum,sumList);
        return sumList;
    }

    public static void CalculateBrachSums(BinaryTree root, int sum, List<int> sumList)
    {
        sum += root.value;

        if (root.left == null && root.right == null)
        {
            sumList.Add(sum);
            return;
        }
        if (root.left != null) 
            CalculateBrachSums(root.left, sum, sumList);
        if(root.right != null)
            CalculateBrachSums(root.right, sum, sumList);
        return;
    }
}