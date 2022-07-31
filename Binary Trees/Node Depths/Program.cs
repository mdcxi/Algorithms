using System;

public class Program
{
    private static int total;
    public static int NodeDepths(BinaryTree root) {
        // Write your code here.
        total = 0;
        NodeDepth(root, 0);
        return total;
    }

    public static void NodeDepth(BinaryTree root, int depth)
    {
        total += depth;
        if(root.left!=null)
            NodeDepth(root.left, depth + 1);
        if(root.right!=null)
            NodeDepth(root.right, depth + 1);
    }
    public class BinaryTree {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value) {
            this.value = value;
            left = null;
            right = null;
        }
    }
}