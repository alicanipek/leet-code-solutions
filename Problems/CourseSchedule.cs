namespace LeetCodeSolutions.Problems {
    public class CourseSchedule {
        public bool CanFinish(int numCourses, int[][] prerequisites) {
            var adjList = new List<List<int>>();
            for (int i = 0; i < numCourses; i++) {
                adjList.Add(new List<int>());
            }

            foreach(var i in prerequisites)
            {
                adjList[i[0]].Add(i[1]);
            }
            bool[] visited = new bool[numCourses];
            bool[] recStack = new bool[numCourses];

            // Call the recursive helper function to detect cycle in different DFS trees
            for (int i = 0; i < numCourses; i++)
                if (!visited[i] && IsCyclicUtil(adjList, i, visited, recStack))
                    return false;

            return true;
        }
        private bool IsCyclicUtil(List<List<int>> adjList, int v, bool[] visited, bool[] recStack)
        {
            if (recStack[v]) // If v is in the recursion stack, there is a cycle
                return true;
            if (visited[v]) // If already visited and not in stack, no cycle here
                return false;

            visited[v] = true; // Mark the current node as visited
            recStack[v] = true; // Add to the recursion stack

            // Check adjacent nodes
            foreach (int neighbor in adjList[v])
            {
                if (IsCyclicUtil(adjList, neighbor, visited, recStack))
                    return true;
            }

            recStack[v] = false; // Remove the vertex from the recursion stack
            return false;
        }
    }
}