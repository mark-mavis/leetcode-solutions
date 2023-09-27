/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public partial class Easy {
    public class RemoveElement {
        public static void Run(){
            Solution(new int[]{1}, 1);
        }
        public static int Solution(int[] nums, int val){
            int start = 0;
            int end = nums.Length-1;
            int count = 0;
            while(start <= end){
                if(nums[end] == val){
                    count++;
                    end--;
                    continue;
                }
                if(nums[start] == val){
                    int temp = nums[end];
                    nums[end] = nums[start];
                    nums[start] = temp;
                    count++;
                    end--;
                }
                start++;
            }
            return nums.Length-count;
        }
        
    }
}
// @lc code=end

