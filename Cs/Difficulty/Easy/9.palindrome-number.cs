/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start

public partial class Easy {
    public class IsPalindrome{
        public static void Run(){
            SolutionI(121);
            SolutionI(-121);
        }
        public static bool SolutionI(int x) {
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
        public static bool SolutionII(int x){
            string strValue = x.ToString();

            int start = 0;
            int end = strValue.Length-1;

            bool isPalindromeFlag = true;

            while(start <= end){
                if(strValue[start] != strValue[end]) isPalindromeFlag = false;
            }
            return isPalindromeFlag;
        }
    }
}
// @lc code=end

