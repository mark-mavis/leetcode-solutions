/*
 * @lc app=leetcode id=36 lang=csharp
 *
 * [36] Valid Sudoku
 */

// @lc code=start
public partial class Medium{
    public class ValidSudoku{
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
            Solution(new char[][]{
            new char[]{'8','3','.','.','7','.','.','.','.'},
            new char[]{'6','.','.','1','9','5','.','.','.'},
            new char[]{'.','9','8','.','.','.','.','6','.'},
            new char[]{'8','.','.','.','6','.','.','.','3'},
            new char[]{'4','.','.','8','.','3','.','.','1'},
            new char[]{'7','.','.','.','2','.','.','.','6'},
            new char[]{'.','6','.','.','.','.','2','8','.'},
            new char[]{'.','.','.','4','1','9','.','.','5'},
            new char[]{'.','.','.','.','8','.','.','7','9'}
            });
            Solution(new char[][]{
            new char[]{'.','1','.','5','2','.','.','.','.'},
            new char[]{'.','.','.','.','.','6','4','3','.'},
            new char[]{'.','.','.','.','.','.','.','.','.'},
            new char[]{'5','.','.','.','.','.','9','.','.'},
            new char[]{'.','.','.','.','.','.','.','5','.'},
            new char[]{'.','.','.','5','.','.','.','.','.'},
            new char[]{'9','.','.','.','.','3','.','.','.'},
            new char[]{'.','.','6','.','.','.','.','.','.'},
            new char[]{'.','.','.','.','.','.','.','.','.'}
            });

        }
        public static bool Solution(char[][] board){
            int i = 0;
            int j = 0;
            while(i < board.Length){
                while(j < board.Length){
                    if(i % 3 == 0 && j % 3 == 0){
                        if(!ValidateSubSquares(board)){
                            return false;
                        }
                    }
                    if(!ValidateRowCol(board, i, j)){
                        return false;
                    }else{
                        i++;
                        j++;
                    }
                }
            }
            return true;
        }

        public static bool ValidateRowCol(char[][] board, int row, int col){
            HashSet<Char> ColSet = new HashSet<char>(){};
            HashSet<Char> RowSet = new HashSet<char>(){};
            // Row Validation
            for(int r = 0; r < board.Length; r++){
                if(board[row][r] == '.') continue;
                if(ColSet.Contains(board[row][r])) return false;
                else ColSet.Add(board[row][r]);
                
            }
            // Column Validation
            for(int c = 0; c < board[0].Length; c++){
                if(board[c][col] == '.') continue;
                if(RowSet.Contains(board[c][col])) return false;
                else RowSet.Add(board[c][col]);
            }
            return true;
        }

        public static bool ValidateSubSquares(char[][] board){
        
        for(int gridRow = 0; gridRow < 9; gridRow += 3){
            for(int gridCol = 0; gridCol < 9; gridCol += 3){
                
                HashSet<char> valSet = new HashSet<char>();
                
                for(int i = gridRow; i < gridRow+3; i++){
                    for(int j = gridCol; j < gridCol+3; j++){
                        if(board[i][j] == '.') continue;
                        if(valSet.Contains(board[i][j])) return false;
                        valSet.Add(board[i][j]);
                    }
                }
            }
        }
        return true;
        }
    }
}
// @lc code=end

