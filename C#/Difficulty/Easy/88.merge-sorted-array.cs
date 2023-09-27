/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public partial class Easy {
    public class MergeSortedArray{
        public static void Run(){
            Solution(new int[]{1,2,3,0,0,0}, 3, new int[]{2,5,6}, 3);
        }
        public static void Solution(int[] nums1, int m, int[] nums2, int n) {
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            for(int i = m, j = 0; i < n1 && j < n2; i++, j++){
                nums1[i] = nums2[j];
            }
            Array.Sort(nums1);
            GC.Collect();
        }
        
    }
    
}
// @lc code=end

