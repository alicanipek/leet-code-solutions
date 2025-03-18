using LeetCodeSolutions.Helper;

namespace LeetCodeSolutions.Problems {
    public class AverageOfLevels {
        public IList<double> Solution(TreeNode root) {
            Queue<TreeNode> queue = new();
            List<double> averages = new();
            queue.Enqueue(root);
            while(queue.Count > 0) {
                int level = queue.Count;
                List<double> currentLevel = new List<double>();

                for (int i = 0; i < level; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    currentLevel.Add(currentNode.Val);

                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }

                averages.Add((double)currentLevel.ToArray().Sum() / currentLevel.Count);

            }
            return averages;

        }
    }

}