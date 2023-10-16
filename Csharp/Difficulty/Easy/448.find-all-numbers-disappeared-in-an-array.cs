/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 */

// @lc code=start
public partial class Easy{ 
    public class FindAllNumbersDisappearedInAnArray{
        public static void Run(){
            
            IList<int> result1 = Solution(new int[]{4,3,2,7,8,2,3,1});
            IList<int> result2 = ImprovedSolution(new int[]{4,3,2,7,8,2,3,1});
        }

        public static IList<int> Solution(int[] nums){
            return Enumerable.Range(1, nums.Length).ToHashSet<int>().Except(nums).ToList();
        }
        public static IList<int> ImprovedSolution(int[] nums){
            int n = nums.Length;
            var result = new List<int>();
            for (int i = 0; i < n; i++) {
                //Grabs the value at the current index, makes it a positive value, the returns it to the outer
                // array indexer-1 to mark that index value negative to show the value that should go there is found
                if (nums[Math.Abs(nums[i])-1] > 0) {
                    nums[Math.Abs(nums[i])-1] *= -1;
                }
            }

            //Iterate through the array and every value that is not negative, that value was not found so add the index value + 1 to a list;
            for (int i = 0; i < n; i++) {
                if (nums[i] > 0) {
                    result.Add(i+1);
                }
            }
            return result;
        }
        public static List<int> ReCodeSolution(int[] nums){
            int n = nums.Length;
            List<int> result = new List<int>();

            for(int i = 0; i < n; i++){
                if(nums[Math.Abs(nums[i])] > 0){    // Pulling out the value at the index and checking the index it should go
                    nums[Math.Abs(nums[i])] *= -1;  // Marking the index that the previous value should be in
                }
            }

            for(int i = 0; i < n; i++){
                if(nums[i] > 0){
                    result.Add(i+1);
                }
            }
            return result;
        }
    }
}
// @lc code=end

