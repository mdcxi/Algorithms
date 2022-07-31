using System;

public class Program {
    public static void InvertBinaryTree(BinaryTree tree) {
        // Write your code here.
        if (tree == null) return;
        SwapLeftAndRight(tree);
        InvertBinaryTree(tree.left);
        InvertBinaryTree(tree.right);
    }

    public static void SwapLeftAndRight(BinaryTree tree)
    {
        BinaryTree left = tree.left;
        tree.left = tree.right;
        tree.right = left;
    }

    public class BinaryTree {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value) {
            this.value = value;
        }
    }
}