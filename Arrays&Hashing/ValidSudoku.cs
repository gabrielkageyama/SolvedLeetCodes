// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

// Each row must contain the digits 1-9 without repetition.
// Each column must contain the digits 1-9 without repetition.
// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
// Note:

// A Sudoku board (partially filled) could be valid but is not necessarily solvable.
// Only the filled cells need to be validated according to the mentioned rules.

// Input: board = 
// [["5","3",".",".","7",".",".",".","."]
// ,["6",".",".","1","9","5",".",".","."]
// ,[".","9","8",".",".",".",".","6","."]
// ,["8",".",".",".","6",".",".",".","3"]
// ,["4",".",".","8",".","3",".",".","1"]
// ,["7",".",".",".","2",".",".",".","6"]
// ,[".","6",".",".",".",".","2","8","."]
// ,[".",".",".","4","1","9",".",".","5"]
// ,[".",".",".",".","8",".",".","7","9"]]
// Output: true
// Example 2:

// Input: board = 
// [["8","3",".",".","7",".",".",".","."]
// ,["6",".",".","1","9","5",".",".","."]
// ,[".","9","8",".",".",".",".","6","."]
// ,["8",".",".",".","6",".",".",".","3"]
// ,["4",".",".","8",".","3",".",".","1"]
// ,["7",".",".",".","2",".",".",".","6"]
// ,[".","6",".",".",".",".","2","8","."]
// ,[".",".",".","4","1","9",".",".","5"]
// ,[".",".",".",".","8",".",".","7","9"]]
// Output: false
// Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.

public class Solution7{
    public bool IsValidSudoku(char[][] board) {
        
        var row = new Dictionary<int, HashSet<char>>();
        var column = new Dictionary<int , HashSet<char>>();
        var threeByThree = new Dictionary<int, HashSet<char>>();

        for(int r = 0; r < 9; r++){
            for(int c = 0; c < 9; c++){
                char unit = board[r][c];
                if(unit == '.')
                    continue;
                if(row.TryGetValue(r, out var rowHSet) && rowHSet.Contains(unit)
                        || column.TryGetValue(c, out var columnHSet) && columnHSet.Contains(unit)
                        || threeByThree.TryGetValue((r / 3) * 3 + c / 3, out var threeByThreeHSet) 
                        && threeByThreeHSet.Contains(unit))
                    return false;

                row.TryAdd(r, new HashSet<char>());
                column.TryAdd(c, new HashSet<char>());
                threeByThree.TryAdd((r / 3) * 3 + c / 3, new HashSet<char>());

                row[r].Add(unit);
                column[c].Add(unit);
                threeByThree[(r / 3) * 3 + c / 3].Add(unit);
            }
        }
        return true;
    }
}
