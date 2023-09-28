/*
 * @lc app=leetcode id=228 lang=csharp
 *
 * [228] Summary Ranges
 */

// @lc code=start
public partial class Easy{  
    public class SummaryRanges{
        public static void Run(){
            IList<string> result = Solution(new int[]{0, 1, 2, 4, 5, 7});
        }
        
        //Sorted
        //Unique Integers
        public static IList<string> Solution(int[] nums){
            IList<string> strings = new List<string>();

            if(nums == null || nums.Length == 0){
                return strings;
            }

            int size = nums.Length;
            int start = nums[0];

            for(int i = 0; i < size; i++){
                if(i < size - 1 && nums[i+1] == nums[i] + 1){
                    continue;
                }

                if(nums[i] == start){
                    strings.Add($"{start}");
                }else{
                    strings.Add($"{start}->{nums[i]}");
                }

                //Update start to current i
                if(i < size - 1){
                    start = nums[i+1];
                }
            }
            return strings;
        }
    }
}
// @lc code=end

