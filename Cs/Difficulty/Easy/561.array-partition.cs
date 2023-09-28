/*
 * @lc app=leetcode id=561 lang=csharp
 *
 * [561] Array Partition
 */

// @lc code=start
public partial class Easy{  
    public class ArrayPartition{
        public static void Run(){
            int result = Solution(new int[]{6, 2, 6, 5, 1, 2});
        }
        public static int Solution(int[] nums){
            int n = nums.Length;
            int sum = 0;
            Array.Sort(nums);
            for(int i = 0; i < n; i = i+2){
                sum += nums[i];
            }

            return sum;
        }
    }
}
// @lc code=end

