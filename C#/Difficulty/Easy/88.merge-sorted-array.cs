/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public partial class Easy {
    public class MergeSortedArray{
        public static void Run(){
            Solution(new int[]{1}, 1, new int[0], 0);
            ImprovedSolution(new int[]{1}, 1, new int[0], 0);
        }
        public static void Solution(int[] nums1, int m, int[] nums2, int n){
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            for(int i = m, j = 0; i < n1 && j < n2; i++, j++){
                nums1[i] = nums2[j];
            }
            Array.Sort(nums1);
        }
        public static void ImprovedSolution(int[] nums1, int m, int[] nums2, int n){
            int nums1Idx = m - 1;   //Setting It to the last element in nums1 array
            int nums2Idx = n - 1;   //Seeting It to the last element in nums2 array
            int combinedIdx = m + n - 1;    //Setting It to the last index in the nums1 array

            while (combinedIdx >= 0)
            {           
                if (nums1Idx < 0 || nums2Idx >= 0 && nums1[nums1Idx] < nums2[nums2Idx])
                {
                    nums1[combinedIdx--] = nums2[nums2Idx--];
                }
                else
                {
                    nums1[combinedIdx--] = nums1[nums1Idx--];
                }
            }
        }
    }
}
// @lc code=end

