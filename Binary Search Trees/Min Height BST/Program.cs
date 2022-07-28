using System;
using System.Collections.Generic;

public class Program {
    public static BST MinHeightBst(List<int> array) {
        // Write your code here.
        return ConstructMinHeightBST(array, 0, array.Count - 1);
    }

    public static BST ConstructMinHeightBST(List<int> array, int startIndex, int endIndex)
    {
        if (endIndex < startIndex) return null;
        int minIndex = (startIndex + endIndex) / 2;
        BST bst = new BST(array[minIndex]);
        bst.left = ConstructMinHeightBST(array, startIndex, minIndex - 1);
        bst.right = ConstructMinHeightBST(array, minIndex + 1, endIndex);
        return bst;
    }

    public class BST {
        public int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
            left = null;
            right = null;
        }

        public void insert(int value) {
            if (value < this.value) {
                if (left == null) {
                    left = new BST(value);
                } else {
                    left.insert(value);
                }
            } else {
                if (right == null) {
                    right = new BST(value);
                } else {
                    right.insert(value);
                }
            }
        }
    }
}