/*
 * @lc app=leetcode id=506 lang=csharp
 *
 * [506] Relative Ranks
 */

// @lc code=start
public partial class Easy{  
    public class RelativeRanks{
        public static void Run(){
            string[] result = Solution(new int[]{10,3,8,9,4});
        }
        public static string[] Solution(int[] score){
            int n = score.Length;
            string[] results = new string[n];

            Stack<string> medals = new Stack<string>();
            medals.Push("Bronze Medal");
            medals.Push("Silver Medal");
            medals.Push("Gold Medal");
            
            Dictionary<int, int> positions = score.Select((value, index) => new {value, index}).ToDictionary( pair => pair.value, pair => pair.index);
            Array.Sort(score);
            Array.Reverse(score);

            for(int i = 0; i < score.Length; i++){
                if(medals.Count > 0){
                    results[positions[score[i]]] = medals.Pop();
                }else{
                    results[positions[score[i]]] = (i+1).ToString();
                }
                

            }
            return results;
        }
    }
}
// @lc code=end

