/*
 * @lc app=leetcode id=500 lang=csharp
 *
 * [500] Keyboard Row
 */

// @lc code=start
public partial class Easy{  
    public class KeyboardRow{
        public static void Run(){
            string[] result = Solution(new string[]{"Hello","Alaska","Dad","Peace"});
        }
        public static string[] Solution(string[] words){
            List<string> result = new List<string>();
            foreach(string str in words){
               if(CheckRows(str)){
                result.Add(str);
               }
            }
            return result.ToArray<string>();
        }
        private static bool CheckRows(string word){
            bool tRowResult = true;
            bool mRowResult = true;
            bool bRowResult = true;
            
            string tRow = "qwertyuiopQWERTYUIOP";
            string mRow = "asdfghjklASDFGHJKL";
            string bRow = "zxcvbnmZXCVBNM";
            
            foreach(char ch in word){
                if(!tRow.Contains(ch)) tRowResult = false;
                if(!mRow.Contains(ch)) mRowResult = false;
                if(!bRow.Contains(ch)) bRowResult = false;

                if(!(tRowResult || mRowResult || bRowResult)){
                    return false;
                }
            }
            return tRowResult || mRowResult || bRowResult;
        }
    }
}
// @lc code=end

