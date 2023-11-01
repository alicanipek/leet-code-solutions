/*
501. Find Mode in Binary Search Tree
Given the root of a binary search tree (BST) with duplicates, return all the mode(s) (i.e., the most frequently occurred element) in it.

If the tree has more than one mode, return them in any order.

Assume a BST is defined as follows:

The left subtree of a node contains only nodes with keys less than or equal to the node's key.
The right subtree of a node contains only nodes with keys greater than or equal to the node's key.
Both the left and right subtrees must also be binary search trees.
*/
public static class FindMode {
    public static int[] FindModeSolution(TreeNode node) {
        var mode = new Dictionary<int, int>();
        InOrderTraversal(node, mode);

        var max = mode.Values.Max();
        return mode.Where(x => x.Value == max).Select(x => x.Key).ToArray();
    }

    private static void InOrderTraversal(TreeNode node, Dictionary<int, int> mode){
        if(node == null)
            return;
        InOrderTraversal(node.left, mode);
        if(mode.ContainsKey(node.val)){
            mode[node.val]++;
        }else{
            mode[node.val] = 1;
        }
        InOrderTraversal(node.right, mode);
    }
}
