/*
 * @lc app=leetcode id=414 lang=csharp
 *
 * [414] Third Maximum Number
 */

// @lc code=start
public partial class Easy{  
    
    public class ThirdMaximumNumber{
        public static void Run(){
            Solution(new int[]{3, 2, 1});
            Solution(new int[]{1, 2});
            Solution(new int[]{2,2,3,1});
            ImprovedTimeComplexity(new int[]{3, 2, 1});
            ImprovedTimeComplexity(new int[]{1, 2});
            ImprovedTimeComplexity(new int[]{2,2,3,1});
        }
        public static int Solution(int[] nums){
            int[] uniqueValues = nums.ToList().Distinct().ToArray();
            if(uniqueValues.Length < 3) return uniqueValues.Max();
            else{
                Array.Sort(uniqueValues);
                Array.Reverse(uniqueValues);
                return uniqueValues[2];
            }
        }
        public static int ImprovedTimeComplexity(int[] nums){
            Array.Sort(nums);
            Array.Reverse(nums);

            int elementCount = 1;
            int prevElement = nums[0];

            for(int i = 0; i < nums.Length; i++){
                if(nums[i] != prevElement){
                    elementCount++;
                    prevElement = nums[i];
                }
                if(elementCount == 3){
                    return nums[i];
                }
            }
            return nums[0];
        }
    }
}
// @lc code=end

