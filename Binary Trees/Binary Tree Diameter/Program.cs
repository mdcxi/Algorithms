using System;

//Node gets its left max path and right max path calculates diameter
//and returns max path to parent
public class Program
{
    private int diameter = 0;
    public int BinaryTreeDiameter(BinaryTree tree) {
        // Write your code here.
        DiameterHelper(tree);
        return diameter;
    }

    public int DiameterHelper(BinaryTree tree)
    {
        int leftCount = 0, rightCount = 0;
        
        if (tree.left == null && tree.right == null) return 0;
        
        if (tree.left != null) leftCount = DiameterHelper(tree.left) + 1;
        if (tree.right != null) rightCount = DiameterHelper(tree.right) + 1;
        
        if ((leftCount + rightCount) > diameter)
            diameter = leftCount + rightCount;
        
        return Math.Max(leftCount, rightCount);
    }

    public class BinaryTree {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;

        public BinaryTree(int value) {
            this.value = value;
        }
    }
}