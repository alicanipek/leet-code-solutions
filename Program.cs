// See https://aka.ms/new-console-template for more information
ValidateBinarySearchTree tree = new ValidateBinarySearchTree();

bool isValid = tree.IsValidBST(new TreeNode(2, new TreeNode(1), new TreeNode(3)));

Console.WriteLine(isValid);
