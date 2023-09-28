/*
 * @lc app=leetcode id=566 lang=csharp
 *
 * [566] Reshape the Matrix
 */

// @lc code=start
public partial class Easy{  
    public class ReshapeTheMatrix{
        public static void Run(){
            int[][] multiArray1 = new int[4][]{
                new int[]{1, 2, 3, 4, 5, 6, 7, 8},
                new int[]{9, 10, 11, 12, 13, 14, 15, 16},
                new int[]{17, 18, 19, 20, 21, 22, 23, 24},
                new int[]{25, 26, 27, 28, 29, 30, 31, 32},
            };
            int[][] multiArray2 = new int[2][]{
                new int[]{1, 2},
                new int[]{3, 4}
            };
            
            Solution(multiArray1, 4, 1);
            Solution(multiArray2, 4, 1);
        }
        public static int[][] Solution(int[][] mat, int r, int c){
            
            int n = mat.Length;
            int m = mat[0].Length;
            
            if (m * n != r * c) {
                return mat;
            }
            
            int[][] arr = new int[r][];
            for (int i = 0; i < r; i++) {
                arr[i] = new int[c];
            }
            
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    int l = i * m + j;
                    arr[l / c][l % c] = mat[i][j];
                }
            }
            
            return arr;
        }
    }
}
// @lc code=end

