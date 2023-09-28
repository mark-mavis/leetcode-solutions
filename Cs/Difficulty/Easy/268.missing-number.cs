/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 */

// @lc code=start
public partial class Easy{  
    public class MissingNumber{
        public static void RuN(){
            int result = Solution(new int[]{0,2});
        }
        public static int Solution(int[] nums){
            
            int maxVal = 0;
            foreach(int val in nums){
                if(val > maxVal) maxVal = val;
            }
            
            //The missing number is outside of the low and high values given
            if(maxVal == nums.Length-1) return maxVal + 1;
            else{
                decimal sum_dec = (((decimal)nums.Length+1)/2)*(0+maxVal);
                int sum = (int)sum_dec;
                foreach(int val in nums){
                    sum -= val;
                }
                return sum;
            }
        }
    }
}
// @lc code=end

