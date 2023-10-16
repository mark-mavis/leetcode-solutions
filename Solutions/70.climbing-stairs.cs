/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */

// @lc code=start
public partial class Easy {
    public class ClimbingStairs{
        public static void Run(){
            Solution(2);
            Solution(44);
        }
        public static int Solution(int n)
        {
            int a = 0, b = 1;
            for (int i = 2; i < n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
    }
}
// @lc code=end

