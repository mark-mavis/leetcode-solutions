/*
 * @lc app=leetcode id=852 lang=csharp
 *
 * [852] Peak Index in a Mountain Array
 */

// @lc code=start
public partial class Medium {
    public class PeakIndexInMountainArray{
        public static void Run(){
            Solution(new int[]{0,1,0});
            Solution(new int[]{0,2,1,0});
            Solution(new int[]{0,10,5,2});
        }

        public static int Solution(int[] arr){
        //BINARY SEARCH
        int left = 0, right = arr.Length, mid;
        
        // Loop until the left and right indexes are reduced to equal each other
        while(left < right){
            
            // Calculate the middle index
            mid = arr.Length/2;

            if(arr[mid] < arr[mid+1]){
                // If the middle index value is less then the index value to the right
                // update the left index to the middle index+1
                left = mid+1;   
            }else{
                // If the middle index value is greater than the index value to the right
                // update the right index to the middle index
                right = mid;
            }
        }
        GC.Collect();
        return left;
        }
    }
}
// @lc code=end

