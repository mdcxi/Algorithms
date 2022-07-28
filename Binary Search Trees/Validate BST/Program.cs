using System;

public class Program
{
    public static bool ValidateBst(BST tree)
    {
        // Write your code here.
        return ValidateBst(tree, Int32.MinValue, Int32.MaxValue);
        return false;
    }

    public static bool ValidateBst(BST tree, int min, int max)
    {
        if (tree == null) return true;
        if (tree.value < min || tree.value >= max) return false;
        bool leftIsValid = ValidateBst(tree.left, min, tree.value);
        bool rightIsValid = ValidateBst(tree.right, tree.value, max);
        return leftIsValid && rightIsValid;
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