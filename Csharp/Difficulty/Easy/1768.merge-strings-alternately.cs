/*
 * @lc app=leetcode id=1768 lang=csharp
 *
 * [1768] Merge Strings Alternately
 */

// @lc code=start
public partial class Easy{
    public class MergeAlternately{
        public static void Run(){

           string result = Solution("abc", "pqr");
           Console.WriteLine(result);
        }
        
        public static string Solution(string word1, string word2){
            int n1 = word1.Length;
            int n = 0;
            int n2 = word2.Length;
            int m = 0;
            char[] result = new char[word1.Length + word2.Length];
            int count = 0;

            while(n < n1 || m < n2){
                if(n < n1){
                    result[count] = word1[n];
                    n++;
                    count++;
                }
                if( m < n2){
                    result[count] = word2[m];
                    m++;
                    count++;
                }
            }

            
            return string.Join("", result);
        }
    }
}
// @lc code=end

