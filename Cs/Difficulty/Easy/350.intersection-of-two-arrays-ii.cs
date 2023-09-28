/*
 * @lc app=leetcode id=350 lang=csharp
 *
 * [350] Intersection of Two Arrays II
 */

// @lc code=start
public partial class Easy{  
    public class IntersectionOfTwoArraysII{
        public static void Run(){
            int[] result = Solution(new int[]{1,2,2,1}, new int[]{2,2});
            result = Solution(new int[]{4,9,5}, new int[]{9,4,9,8,4});
        }
        public static int[] Solution(int[] nums1, int[] nums2){
            Dictionary<int, int> values = new Dictionary<int, int>();
            foreach(int val in nums1){
                if(!values.ContainsKey(val)){
                    values.Add(val, 1);
                }else{
                    values[val]++;
                }
            }

            List<int> list = new List<int>();

            foreach(int val in nums2){
                if(values.ContainsKey(val)){
                    list.Add(val);
                    values[val]--;
                    if(values[val] == 0) values.Remove(val);
                }
            }

            return list.ToArray();
        }
    }
}
// @lc code=end

