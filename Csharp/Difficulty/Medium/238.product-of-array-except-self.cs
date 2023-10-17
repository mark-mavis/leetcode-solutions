/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public partial class Medium {
    public class ProductOfArrayExcept{
        public static void Run(){

            ProductExceptSelf(new int[]{1, 2, 3, 4});
            ProductExceptSelf(new int[]{-1, 1, 0, -3, 3});
        }
        public static int[] ProductExceptSelf(int[] nums) {

        int[] products = new int[nums.Length];
        int num = 1, i;

        for( i=0; i < nums.Length; i++){
            products[i] = num;
            num *= nums[i];
        }
        num = 1;

        for( i = nums.Length-1; i >= 0; i--){
            products[i] *= num;
            num *= nums[i];
        }

        return products;
        }
    }
    
}
// @lc code=end

