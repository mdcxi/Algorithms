using System;

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

	public bool ValidateThreeNodes(BST nodeOne, BST nodeTwo, BST nodeThree) {
		// Write your code here.
		if (isDescendant(nodeTwo, nodeOne)) return isDescendant(nodeThree, nodeTwo);
		if (isDescendant(nodeTwo, nodeThree)) return isDescendant(nodeOne, nodeTwo);
		return false;
	}
	
	//whether the "target" is a descendant of the "node"
	public bool isDescendant (BST node, BST target)
	{
		while (node !=null && node != target)
		{
			node = (target.value < node.value) ? node.left : node.right;
		}

		return node == target;
	}
}
