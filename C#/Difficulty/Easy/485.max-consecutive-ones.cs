/*
 * @lc app=leetcode id=485 lang=csharp
 *
 * [485] Max Consecutive Ones
 */

// @lc code=start
public partial class Easy{  
    public class MaxConsecutiveOnes{
        public static void Run(){
           Solution(new int[]{1, 1, 0, 1, 1, 1});
        }
        public static int Solution(int[] nums){
            int maxOneCount = 0;
            int currOneCount = 0;
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] == 1){
                    currOneCount++;
                    if(currOneCount > maxOneCount) maxOneCount = currOneCount;
                    continue;
                }
                currOneCount = 0;
            }
            return maxOneCount;
        }
    }
}
// @lc code=end

