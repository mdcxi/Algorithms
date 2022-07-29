using System;

public class Program
{
    // This is an input class. Do not edit.
    public class BST
    {
        public int value;
        public BST left = null;
        public BST right = null;

        public BST(int value)
        {
            this.value = value;
        }
    }

    public int FindKthLargestValueInBst(BST tree, int k)
    {
        // Write your code here.
        return ReverseOrderTraverseAndFind(tree, k, new int[1]);
    }

    public int ReverseOrderTraverseAndFind(BST tree, int k, int[] count)
    {
        //if count > k, we have found value already
        if (tree == null || count[0] > k) return 0;
        
        int r = ReverseOrderTraverseAndFind(tree.right, k, count);
        //by treating count as a reference value, we persist it across recursive calls
        if ((count[0] += 1) == k) return tree.value;
        
        int l = ReverseOrderTraverseAndFind(tree.left, k, count);
        return l + r; //we will always find one value, so we can simply return the sum
    }
}