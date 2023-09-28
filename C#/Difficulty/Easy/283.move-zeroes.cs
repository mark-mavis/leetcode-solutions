/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
public partial class Easy{  
    public class MoveZeros{
        public static void Run(){
            Solution(new int[]{0, 1, 0, 3, 12});
        }
        public static void Solution(int[] nums){
            if(nums == null || nums.Length == 0){
                return;
            }

            int placementIT = 0;
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] != 0){
                    int temp = nums[placementIT];
                    nums[placementIT] = nums[i];
                    nums[i] = temp;
                    placementIT++;
                }
            }
        }
    }
}
// @lc code=end

