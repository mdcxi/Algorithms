using System;

public class Program {
    public class BST {
        public int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
        }

        public BST Insert(int value) {
            // Write your code here.
            if (value < this.value)
            {
                if (left == null)
                {
                    BST newBST = new BST(value);
                    left = newBST;
                }
                else
                {
                    left.Insert(value);
                }
            }
            else
            {
                if (right == null)
                {
                    BST newBST = new BST(value);
                    right = newBST;
                }
                else
                {
                    right.Insert(value);
                }
            }
            // Do not edit the return statement of this method.
            return this;
        }

        public bool Contains(int value) {
            // Write your code here.
            if (value < this.value)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.Contains(value);
                }
            }
            else if (value > this.value)
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.Contains(value);
                }
            }
            else
            {
                return true;
            }
        }

        public BST Remove(int value) {
            // Write your code here.
            Remove(value, null);
            // Do not edit the return statement of this method.
            return this;
        }

        public void Remove(int value, BST parent)
        {
            if (value < this.value)
            {
                if (left != null)
                {
                    left.Remove(value, this);
                }
            }
            else if (value > this.value)
            {
                if (right != null)
                {
                    right.Remove(value, this);
                }
            }
            else
            {
                if (left != null && right != null)
                {
                    this.value = right.getMinValue();
                    right.Remove(this.value, this);
                }
                else if (parent == null)
                {
                    if (left != null)
                    {
                        this.value = left.value;
                        right = left.right;
                        left = left.left;
                    }
                    else if (right != null)
                    {
                        this.value = right.value;
                        left = right.left;
                        right = right.right;
                    }
                    else
                    {
                        //this is a single-node tree; do nothing
                    }
                }
                else if (parent.left==this)
                {
                    parent.left = left != null ? left : right;
                }
                else if (parent.right == this)
                {
                    parent.right = left != null ? left : right;
                }
            }
        }

        public int getMinValue()
        {
            if (left == null)
            {
                return this.value;
            }
            else
            {
                return left.getMinValue();
            }
        }
    }
}