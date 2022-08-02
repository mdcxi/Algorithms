using System;

public class Program {
    // This is an input class. Do not edit.
    public class BinaryTree {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;

        public BinaryTree(int value) {
            this.value = value;
        }
    }

    public bool HeightBalancedBinaryTree(BinaryTree tree) {
        // Write your code here.
        return MaxDepth(tree) >= 0;
    }

    public int MaxDepth(BinaryTree tree)
    {
        if (tree == null) return 0;

        int leftDepth = MaxDepth(tree.left);
        int rightDepth = MaxDepth(tree.right);

        if (leftDepth < 0 || rightDepth < 0 || Math.Abs(leftDepth - rightDepth) > 1)
            return -1;
        
        return Math.Max(leftDepth, rightDepth) + 1;
    }
}