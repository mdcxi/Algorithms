using System;

public class Program
{
    private static int maxPath;
    
    public static int MaxPathSum(BinaryTree tree) {
        // Write your code here.
        maxPath = Int32.MinValue;
        FindMaxSum(tree);
        return maxPath;
    }

    public class BinaryTree {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value) {
            this.value = value;
        }
    }

    public static int FindMaxSum(BinaryTree tree)
    {
        if (tree == null) return 0;
        int leftSum = Math.Max(FindMaxSum(tree.left), 0);
        int rightSum = Math.Max(FindMaxSum(tree.right), 0);
        maxPath = Math.Max(maxPath, tree.value + leftSum + rightSum);
        return tree.value + Math.Max(leftSum, rightSum);
    }
}