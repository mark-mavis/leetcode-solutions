/*
 * @lc app=leetcode id=349 lang=csharp
 *
 * [349] Intersection of Two Arrays
 */

// @lc code=start
public partial class Easy{  
    public class IntersectionOfTwoArrays{
        public static void Run(){
            Solution(new int[]{1, 2, 2, 1}, new int[]{2, 2});
        }
        public static int[] Solution(int[] nums1, int[] nums2){
            return nums1.Intersect(nums2).ToArray();
        }

    }
}
// @lc code=end

