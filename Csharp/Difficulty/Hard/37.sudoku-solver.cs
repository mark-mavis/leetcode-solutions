/*
 * @lc app=leetcode id=37 lang=csharp
 *
 * [37] Sudoku Solver
 */

// @lc code=start
public partial class Hard {
    public class SudukoSolver{
        public static void Run(){
            Solution(new char[][]{
                new char[]{'5','3','.','.','7','.','.','.','.'},
                new char[]{'6','.','.','1','9','5','.','.','.'},
                new char[]{'.','9','8','.','.','.','.','6','.'},
                new char[]{'8','.','.','.','6','.','.','.','3'},
                new char[]{'4','.','.','8','.','3','.','.','1'},
                new char[]{'7','.','.','.','2','.','.','.','6'},
                new char[]{'.','6','.','.','.','.','2','8','.'},
                new char[]{'.','.','.','4','1','9','.','.','5'},
                new char[]{'.','.','.','.','8','.','.','7','9'}
            });
        }
        public static bool Solution(char[][] board){
            int dimension = board.Length;
            (int, int)? result = FindEmptyCell(board, dimension);
            if( result == null){
                return true;
            }
            for(int i = 0; i < 10; i++){
                if(IsValid(board, result.Value.Item1, result.Value.Item2, i)){
                    board[result.Value.Item1][result.Value.Item2] = Convert.ToChar(i);
                }
            }
            return false;
        }
        public static (int, int)? FindEmptyCell(char[][] board, int dimension){
            for(int i = 0; i < dimension; i++){
                for(int j = 0; j < dimension; j++){
                    if(board[i][j] == '.'){
                        return (i, j);
                    }
                }
            }
            return null;
        }
        public static bool IsValid(char[][] board, int row, int col, int digit){
            return true;
        }
    }
}
// @lc code=end

