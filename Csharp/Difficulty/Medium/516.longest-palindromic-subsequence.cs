/*
 * @lc app=leetcode id=516 lang=csharp
 *
 * [516] Longest Palindromic Subsequence
 */

// @lc code=start
public partial class Medium {
    public class LongestPalindromicSubString{
        public static void Run(){
            Solution("babad");
            Solution("cbbd");
        }

        public static string Solution(string s){
            string result = "";
            for(int left = 0; left < s.Length; left++){
                int right = s.Length-1;
                while(right >= left){
                    if(s[left] == s[right] && IsValidPalindrome(s, left, right)){
                        result = (s.Substring(left, (right - left)+1).Length > result.Length) ? s.Substring(left, (right - left)+1) : result;
                        break;
                    }
                    right--;
                }
            }
            return result;
        }
        public static bool IsValidPalindrome(string s, int left, int right){
            while(left < right){
                if(s[left] != s[right]) return false;
                left++;
                right--;
            }
            return true;

        }
    }
}
// @lc code=end

