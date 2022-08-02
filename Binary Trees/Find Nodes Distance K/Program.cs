using System.Collections.Generic;
using System;


public class Program {
    // This is an input class. Do not edit.
    public class BinaryTree {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;

        public BinaryTree(int value) {
            this.value = value;
        }
    }
    
    public List<int> FindNodesDistanceK(BinaryTree tree, int target, int k) {
        // Write your code here.
        List<int> nodesDistanceK = new List<int>();
        FindDistance_FromNodeToTarget(tree, target, k, nodesDistanceK);
        return nodesDistanceK;
    }

    public int FindDistance_FromNodeToTarget(BinaryTree tree, int target, int k,
        List<int> nodesDistanceK)
    {
        if (tree == null) return -1;
        
        if (tree.value == target)
        {
            AddSubtreeNodeAtDistanceK(tree,0,k,nodesDistanceK);
            return 1;
        }

        int leftDistance = FindDistance_FromNodeToTarget(tree.left, target, k, nodesDistanceK);
        int rightDistance = FindDistance_FromNodeToTarget(tree.right, target, k, nodesDistanceK);
        
        if(leftDistance == k || rightDistance == k) nodesDistanceK.Add(tree.value);
        
        if (leftDistance != -1)
        {
            AddSubtreeNodeAtDistanceK(tree.right, leftDistance + 1,k,nodesDistanceK);
            return leftDistance + 1;
        }
        
        else if (rightDistance != -1)
        {
            AddSubtreeNodeAtDistanceK(tree.left, rightDistance+1,k,nodesDistanceK);
            return rightDistance + 1;
        }
        
        return -1;
    }

    public void AddSubtreeNodeAtDistanceK(BinaryTree tree, int distance, int k,
        List<int> nodesDistanceK)
    {
        if (tree == null) return;
        
        if (distance == k)
        {
            nodesDistanceK.Add(tree.value);
        }
        else
        {
            AddSubtreeNodeAtDistanceK(tree.left, distance + 1,k, nodesDistanceK);
            AddSubtreeNodeAtDistanceK(tree.right, distance + 1, k, nodesDistanceK);
        }
    }
}