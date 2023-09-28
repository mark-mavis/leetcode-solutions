/*
 * @lc app=leetcode id=303 lang=csharp
 *
 * [303] Range Sum Query - Immutable
 */

// @lc code=start
public partial class Easy{  
    public class RangeSumQueryImmutable {

        private int[] arr;

        public RangeSumQueryImmutable(int[] nums) {
            arr = nums;
        }
        
        public int SumRange(int left, int right) {
            return arr[left..(right+1)].Sum();
        }
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
// @lc code=end

