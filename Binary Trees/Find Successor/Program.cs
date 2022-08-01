using System;

public class Program {
	// This is an input class. Do not edit.
	public class BinaryTree {
		public int value;
		public BinaryTree left = null;
		public BinaryTree right = null;
		public BinaryTree parent = null;

		public BinaryTree(int value) {
			this.value = value;
		}
	}


	public BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node) {
		// Write your code here.
		if (node.right != null)
		{
			return GetLeftMostNode(node.right);
		}
		else
		{
			BinaryTree parent = node.parent;
			BinaryTree child = node;
			while (parent != null)
			{
				if (child == parent.left)
				{
					return parent;
				}

				child = parent;
				parent = parent.parent;
			}
		}
		return null;
	}

	public BinaryTree GetLeftMostNode(BinaryTree node)
	{
		if (node.left == null) return node;
		return GetLeftMostNode(node.left);
	}
}

