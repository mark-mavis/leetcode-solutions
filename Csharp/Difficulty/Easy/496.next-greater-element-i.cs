/*
 * @lc app=leetcode id=496 lang=csharp
 *
 * [496] Next Greater Element I
 */

// @lc code=start
public partial class Easy{  
    public class NextGreaterElement{
        public static void Run(){
            int[] result = Solution(new int[]{4, 1, 2}, new int[]{1, 3, 4, 2});
        }
        public static int[] Solution(int[] nums1, int[] nums2){
            //int[] results = new int[nums1.Length];
            Dictionary<int, int> values = nums2.Select((value, index) => new {value, index}).ToDictionary(pair => pair.value, pair => pair.index);
            
            for(int i = 0; i < nums1.Length; i++){
                int curVal = nums1[i];
                int startPos = values[curVal];
                if(startPos+1 < nums2.Length){
                    for(int j = startPos+1; j < nums2.Length; j++){
                        if(nums2[j] > curVal) curVal = nums2[j];
                    }
                    if(curVal == nums1[i]) nums1[i] = -1;
                    else nums1[i] = curVal;
                }else{
                    nums1[i] = -1;
                }
            }
            return nums1;
        }
    }
}
// @lc code=end

