using System;

public class Program {
    public static int FindClosestValueInBst(BST tree, int target) {
        // Write your code here.
        int closestValue = 0;
        int absDiff = Int32.MaxValue;

        while (tree!=null)
        {
            int currentDiff = Math.Abs(tree.value - target);
            if (currentDiff < absDiff)
            {
                absDiff = currentDiff;
                closestValue = tree.value;
            }

            if (target == tree.value)
            {
                return tree.value;
            }
            else if (target > tree.value)
            {
                tree = tree.right;
            }
            else
            {
                tree = tree.left;
            }
        }
        return closestValue;
    }

    public class BST {
        public int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
        }
    }
}