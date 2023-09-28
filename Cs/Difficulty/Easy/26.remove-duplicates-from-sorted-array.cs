/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public partial class Easy {
    public class RemoveDuplicates{

        public static void Run(){
            Solution(new int[]{0,0,1,1,1,2,2,3,3,4});
            ImprovedSolution(new int[]{0,0,1,1,1,2,2,3,3,4});
        }

        public static int Solution(int[] nums){
            HashSet<int> hash = new HashSet<int>();
            int positionIt = 0;
            for(int i = 0; i < nums.Length; i++){
                int temp = nums[i];
                if(!hash.Contains(temp)){
                    hash.Add(temp);
                    nums[positionIt] = temp;
                    positionIt++;
                }
            }
            GC.Collect();
            return hash.Count();
        }
        public static int ImprovedSolution(int[] nums){

            int previousFound = int.MinValue;
            int positionIt = 0;
            int count = 0;

            for(int i = 0; i < nums.Length; i++){
                if(previousFound != nums[i]){
                    previousFound = nums[i];
                    nums[positionIt] = nums[i];
                    positionIt++;
                    count++;
                }
            }
            return count;
        }
        
    }
}
// @lc code=end

