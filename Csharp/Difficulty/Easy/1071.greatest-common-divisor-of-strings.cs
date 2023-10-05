/*
 * @lc app=leetcode id=1071 lang=csharp
 *
 * [1071] Greatest Common Divisor of Strings
 */

// @lc code=start
public partial class Easy{
    public class GreatestCommonDivisorOfStrings {
        public static void Run(){
            string result = Solution("ABCABC", "ABC");
        }
        public static string Solution(string str1, string str2) {
            
            int len1 = str1.Length;
            int len2 = str2.Length;

            if((str1+str2).Equals(str2+str1)){
                int index = GCD(len1, len2);
                return str1.Substring(0, index);
            }else{
                return "";
            }
        }
        private static int GCD(int length1, int length2){
            if(length2 == 0){
                Console.WriteLine($"Returning Length1: {length1}");
                return length1;
            }else{
                Console.WriteLine($"Length2: {length2}, Length1 % Length2: {length1 % length2}");
                return GCD(length2, length1 % length2);
            }
        }
    }
}

// @lc code=end

