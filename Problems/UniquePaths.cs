namespace LeetCodeSolutions.Problems {
    public class UniquePaths {
        public int FindUniquePaths(int m, int n) {
            int[,] grid = new int[n, m];
            grid[0, 0] = 1;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (i == 0 || j == 0) {
                        grid[i, j] = 1;
                    } else {
                        grid[i, j] = grid[i - 1, j] + grid[i, j - 1];
                    }
                }
            }
            return grid[n - 1, m - 1];
        }
    }
}