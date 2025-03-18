
namespace LeetCodeSolutions.Problems {
    public class SurroundedRegions {
        public void Solve(char[][] board) {
            var m = board.Length;
            var n = board[0].Length;
            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    if(board[i][j] == 'O') {
                        if(i-1 < 0 || i+1 >= m || j-1 < 0 || j+1 >= n) continue;
                        Dfs(i, j);
                    }
                }
            }
            void Dfs(int i, int j) {
                if(i < 0 || i >= m || j < 0 || j >= n || board[i][j] != 'O')
                    return;
                else {
                    board[i][j] = 'X';
                    Dfs(i, j + 1);
                    Dfs(i + 1, j);
                    Dfs(i, j - 1);
                    Dfs(i - 1, j);
                }
            }
        }
    }
}