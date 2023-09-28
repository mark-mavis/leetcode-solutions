/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start
public partial class Easy{  
    
    public class ContainsDuplicate1{
        public static void Run(){
            bool result = Solution(new int[]{1, 0, 1, 1}, 1);
        }
        public static bool Solution(int[] nums){
            Dictionary<int, bool> values = new Dictionary<int, bool>();
            foreach(int val in nums){
                if(!values.ContainsKey(val)){
                    values.Add(val, true);
                }else{
                    return values[val];
                }
            }
            return false;
        }
    }
}
// @lc code=end

