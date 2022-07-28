using System;
using System.Collections.Generic;

public class Program {
    public static List<int> InOrderTraverse(BST tree, List<int> array) {
        // Write your code here.
        if (tree == null) return array;
        InOrderTraverse(tree.left, array);
        array.Add(tree.value);
        InOrderTraverse(tree.right, array);
        return array;
    }

    public static List<int> PreOrderTraverse(BST tree, List<int> array) {
        // Write your code here.
        if (tree == null) return array;
        array.Add(tree.value);
        PreOrderTraverse(tree.left, array);
        PreOrderTraverse(tree.right, array);
        return array;
    }

    public static List<int> PostOrderTraverse(BST tree, List<int> array) {
        // Write your code here.
        if (tree == null) return array;
        PostOrderTraverse(tree.left, array);
        PostOrderTraverse(tree.right, array);
        array.Add(tree.value);
        return array;
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