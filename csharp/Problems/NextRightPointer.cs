using LeetCodeSolutions.Helper;

namespace LeetCodeSolutions.Problems {
    public class NextRightPointer
    {
        public Node Connect(Node root) {
            Queue<Node> queue = new();
            queue.Enqueue(root);
            while(queue.Count > 0) {
                int level = queue.Count;
                List<Node> currentLevel = new List<Node>();

                for (int i = 0; i < level; i++)
                {
                    Node currentNode = queue.Dequeue();
                    currentLevel.Add(currentNode);

                    if (currentNode.left != null)
                        queue.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                }

    			for (int i = 1; i < currentLevel.Count; i++)
    			{
    				currentLevel[i - 1].next = currentLevel[i];
    			}

            }
            return root;
        }
    }
}
