/*
 * @lc app=leetcode id=151 lang=csharp
 *
 * [151] Reverse Words in a String
 */

// @lc code=start
using System.Reflection.Metadata;
using System.Text;

public partial class Medium {
    public class ReverseWordsInAString{
        public static void Run(){
            ImprovedReverseWords("    hello world    ");
            Console.WriteLine(ReverseWords("the sky is blue"));
            Console.WriteLine(ReverseWords("   hello world   "));
            Console.WriteLine(ReverseWords("EPY2giL"));

        }

        public static string ReverseWords(string s) {
            HashSet<StringBuilder> strings = new HashSet<StringBuilder>();
            for(int i = 0; i < s.Length;){
                if(Char.IsLetter(s[i])){
                    StringBuilder sb = Helper(s, i);
                    strings.Add(sb);
                    i += sb.Length-1;
                }
                i++;
            }
            
            return String.Join(' ', strings.Reverse());
        }

        public static string ImprovedReverseWords(string s){
            List<string> strs = s.Split(" ").Where(x => x != "").ToList();
            StringBuilder sb = new();
            for(int i = strs.Count-1; i >= 0; i--){
                if(strs[i] != ""){
                    sb.Append(strs[i]);
                    if(i != 0) sb.Append(" ");
                }
            }
            return sb.ToString();
        }

        private static StringBuilder Helper(string str, int indexStart){
            StringBuilder sb = new StringBuilder();
            while(indexStart < str.Length && Char.IsLetter(str[indexStart])){
                sb.Append(str[indexStart]);
                indexStart++;
            }
            return sb;
        }
    }
}
// @lc code=end

