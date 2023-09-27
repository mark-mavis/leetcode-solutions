/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start

public partial class Easy {
    public class IsPalindrome{
        public static void Run(){
            Solution(121);
            Solution(-121);
        }
        public static bool Solution(int x) {
            string strValue = x.ToString();

            int start = 0;
            int end = strValue.Length-1;

            while(start <= end){
                if(strValue[start] != strValue[end]) {
                    GC.Collect();
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
    
    
}
// @lc code=end

