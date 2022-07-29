using System.Collections.Generic;
using System;

//O(n^2) time complexity
public class Program {
    // This is an input class. Do not edit.
    public class BST {
        public int value;
        public BST left = null;
        public BST right = null;

        public BST(int value) {
            this.value = value;
        }
    }

    public static void Add(BST bst, int value)
    {
        if (value < bst.value)
        {
            if (bst.left == null)
            {
                bst.left = new BST(value);
            }
            else
            {
                Add(bst.left, value);
            }
        }
        else
        {
            if (bst.right == null)
            {
                bst.right = new BST(value);
            }
            else
            {
                Add(bst.right, value);
            }
        }
    }

    public BST ReconstructBst(List<int> preOrderTraversalValues) {
        // Write your code here.
        if(preOrderTraversalValues.Count ==0) return null;

        BST root = new BST(preOrderTraversalValues[0]);
        for (int i = 1; i < preOrderTraversalValues.Count; i++)
        {
            Program.Add(root, preOrderTraversalValues[i]);
        }

        return root;
    }
}