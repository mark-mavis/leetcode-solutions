/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
public partial class Easy {
    public class SearchInsertPosition{

        public static void Run(){
            Solution(new int[]{1,3,5,6}, 2);
            ImprovedSolution(new int[]{1,3,5,6}, 2);
        }   

        public static int Solution(int[] nums, int target){
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] >= target) return i;
            }
            GC.Collect();
            return nums.Length;
        }
        public static int ImprovedSolution(int[] nums, int target){
            int left = 0;
            int right = nums.Length-1;

            while(left <= right){
                int mid = (right - left)/2;
                if(nums[mid] == target){
                    return mid;
                }else if(nums[mid] < target){
                    left = mid + 1;
                }else{
                    right = mid - 1;
                }
            }
            return left;
        }     
    }
}
// @lc code=end

