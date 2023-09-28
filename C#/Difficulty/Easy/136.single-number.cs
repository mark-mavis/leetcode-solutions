/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 */

// @lc code=start
public partial class Easy{  
    public class SingleNumber{
        public static void Run(){
            Solution(new int[]{4, 1, 2, 1, 2});
            ImprovedSolution(new int[]{4, 1, 2, 1, 2});

        }
        public static int Solution(int[] nums){
            /*
                Cases: 
                1) No empty arrays.
                2) One Number Array.
                3) Many number arrays
            */
            Array.Sort(nums);
            for(int i = 0; i < nums.Length-1; i+=2){
                if(nums[i] == nums[i+1]){
                    continue;
                }else{
                    return nums[i];
                }
            }
            return nums[nums.Length-1];
        }

        public static int ImprovedSolution(int[] nums){
            var singleNumber = 0;
            foreach(var item in nums)   
            {
                singleNumber ^= item;
            }
            return singleNumber;
        }
    }
}
// @lc code=end

