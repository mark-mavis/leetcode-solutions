/*
 * @lc app=leetcode id=334 lang=csharp
 *
 * [334] Increasing Triplet Subsequence
 */

// @lc code=start
public partial class Medium {
    public class IncreasingTripletSubsequence{
        public static void Run(){
            IncreasingTriplet(new int[]{2, 1, 5, 0, 4, 6});

        }
        public static bool IncreasingTriplet(int[] nums) {
            
            if(nums.Length < 3) return false;
            for(int i = 1; i < nums.Length-1; i++){
                if(nums[i-1] < nums[i] && nums[i] < nums[i+1]) return true;
            }
            return false;
        }
    }
    
}
// @lc code=end

