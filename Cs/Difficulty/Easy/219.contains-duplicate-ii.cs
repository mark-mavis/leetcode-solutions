/*
 * @lc app=leetcode id=219 lang=csharp
 *
 * [219] Contains Duplicate II
 */

// @lc code=start
public partial class Easy{  
    public class ContainsDuplicateII{
        public static void Run(){
            bool result = Solution(new int[]{1, 0, 1, 1}, 1);
        }
        public static bool Solution(int[] nums, int k){
            Dictionary<int, int> kvp = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++){
                int curVal = nums[i];
                if(!kvp.ContainsKey(curVal)){
                    kvp.Add(curVal, i);
                }else{
                    if( (Math.Abs(kvp[curVal] - i) <= k) && (curVal == nums[kvp[curVal]]) ) return true;
                    else kvp[curVal] = i;
                }
            }
            return false;
        }
    }
}
// @lc code=end

