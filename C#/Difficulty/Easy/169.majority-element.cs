/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */

// @lc code=start
public partial class Easy{  
    public class MajorityElement{
        public static void Run(){


            MemorySolution(new int[]{3,2,3});
            MemorySolution(new int[]{2,2,1,1,1,2,2});
            RuntimeSolution(new int[]{3,2,3});
            RuntimeSolution(new int[]{2,2,1,1,1,2,2});
        }

        public static int MemorySolution(int[] nums){
            int mid = nums.Length/2;
            Array.Sort(nums);
            GC.Collect();
            return nums[mid];
        }

        public static int RuntimeSolution(int[] nums){
            Dictionary<int, int> ValueCounts = new Dictionary<int, int>(2);
            foreach(int val in nums){
                if(!ValueCounts.ContainsKey(val)){
                    ValueCounts.Add(val, 1);
                }else{
                    ValueCounts[val]++;
                }
            }
            int maxValue = 0;
            int maxKey = -1;
            foreach(KeyValuePair<int, int> kvp in ValueCounts){
                if(kvp.Value > maxValue){
                    maxValue = kvp.Value;
                    maxKey = kvp.Key;
                }
            }
            return maxKey;

        }
    }
}
// @lc code=end

