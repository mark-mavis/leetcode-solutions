/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start

public partial class Easy {
    public class TwoSum{
        public static void Run(){
            Solution(new int[]{2,7,11,15}, 9);
        }

        public static int[] Solution(int[] nums, int target) {
        Dictionary<int, int> lookup = new();
        for(int i = 0; i < nums.Length; i++){
            if(lookup.ContainsKey(nums[i])){
                GC.Collect();
                return new int[]{i, lookup[nums[i]]};
            }
            lookup[target-nums[i]] = i;
        }
        return new int[]{-1, -1};
        }
    }
}
    
    

// @lc code=end

