/*
 * @lc app=leetcode id=108 lang=csharp
 *
 * [108] Convert Sorted Array to Binary Search Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public partial class Easy{
    public class ConvertSortedArrayToBinaryTree{
        public static void Run(){
            SortedArrayToBST(new int[]{-10,-3,0,5,9});

        }
        public static HelperObjects.TreeNode? SortedArrayToBST(int[] nums) {
            if(nums == null || nums.Length == 0)
                return null;
                
            return ConstructBSTRecursive(nums, 0, nums.Length - 1);           
        }

        public static HelperObjects.TreeNode? ConstructBSTRecursive(int[] nums, int left, int right){
            
            if(left > right) return null;
            int midpoint = left + (right - left)/2;
            HelperObjects.TreeNode node = new HelperObjects.TreeNode(nums[midpoint]);
            node.left = ConstructBSTRecursive(nums, left, midpoint-1);
            node.right = ConstructBSTRecursive(nums, midpoint+1, right);
            return node;
        }   
    }
}
// @lc code=end

