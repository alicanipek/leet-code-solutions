/*
98. Validate Binary Search Tree
Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

  - The left subtree of a node contains only nodes with keys less than the node's key.
  - The right subtree of a node contains only nodes with keys greater than the node's key.
  - Both the left and right subtrees must also be binary search trees.
*/

using LeetCodeSolutions.Helper;

namespace LeetCodeSolutions.Problems {
    public class ValidateBinarySearchTree {
        public bool IsValidBST(TreeNode root) => validate(root, null, null);

        public bool validate(TreeNode root, int? low, int? high){
            if(root == null) return true;
            if((low != null && root.Val <= low) || (high != null && root.Val >= high)) return false;
            return validate(root.Right, root.Val, high) && validate(root.Left, low, root.Val);
        }
    }
}