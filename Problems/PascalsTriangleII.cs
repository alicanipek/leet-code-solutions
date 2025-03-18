/*
119. Pascal's Triangle II
Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.
*/

namespace LeetCodeSolutions.Problems {
    public static class PascalsTriangleII {
        public static IList<int> GetRow(int rowIndex) {
            if(rowIndex == 0) {
                return new List<int> { 1 };
            }
            if(rowIndex == 1) {
                return new List<int> { 1, 1 };
            }
            var rowNumber = 2;

            var nextRow = new List<int> { 1, 2, 1 };
            while(rowNumber < rowIndex) {
                nextRow = GetNextRow(nextRow);
                rowNumber++;
            }
            return nextRow;
        }

        private static List<int> GetNextRow(List<int> row) {
            var newRow = new List<int> { 1 };

            for(int i = 0; i < row.Count - 1; i++) {
                newRow.Add(row[i] + row[i + 1]);
            }

            newRow.Add(1);
            return newRow;
        }

    }
}