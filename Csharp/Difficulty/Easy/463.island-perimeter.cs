/*
 * @lc app=leetcode id=463 lang=csharp
 *
 * [463] Island Perimeter
 */

// @lc code=start
public partial class Easy{
    
    public class IslandPerimeter{
        public static void Run(){
            Solution(new int[][]{
                new int[]{0, 1, 0, 0}, 
                new int[]{1, 1, 1, 0}, 
                new int[]{0, 1, 0, 0}, 
                new int[]{1, 1, 0, 0}
            });
        } 
        public static int Solution(int[][] grid){
            int totalPerimeter = 0;
            int m = grid.Length;
            int n = grid[0].Length;
            for(int i = 0; i < m; i++){
                for(int j = 0; j < n; j++){
                    if(grid[i][j] == 1){
                        int localparameter = 4;
                        //Verticle Checks
                        if((i+1) < m && grid[i+1][j] == 1) localparameter -= 1;
                        if((i-1) >= 0 && grid[i-1][j] == 1) localparameter -= 1;
                        //Horizontal Checks
                        if((j+1) < n && grid[i][j+1] == 1) localparameter -= 1;
                        if((j-1) >= 0 && grid[i][j-1] == 1) localparameter -= 1;

                        totalPerimeter += localparameter;
                    }
                }
            }
            return totalPerimeter;
        }
    }
}
// @lc code=end

