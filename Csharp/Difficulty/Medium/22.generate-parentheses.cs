/*
 * @lc app=leetcode id=22 lang=csharp
 *
 * [22] Generate Parentheses
 */

// @lc code=start
public partial class Mediuam{
    public class Solution {
        public IList<string> Run(int n){
            IList<string> result = new List<string>();
            GenerateParentheses(result, "(", 1, 0, n);
            return result;
        }
        public void GenerateParentheses(IList<string> result, string curr, int open, int close, int n){
            if(curr.Length == 2*n){
                result.Add(curr);
                return;
            }
            if(open < n){
                GenerateParentheses(result, curr+"(", open+1, close, n);
            }
            if(close < open){
                GenerateParentheses(result, curr+")", open, close+1, n);
            }
        }
        
    }
}

// @lc code=end

