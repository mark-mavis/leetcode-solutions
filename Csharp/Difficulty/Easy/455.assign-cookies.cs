/*
 * @lc app=leetcode id=455 lang=csharp
 *
 * [455] Assign Cookies
 */

// @lc code=start
public partial class Easy {
    public class AssignCookies{
        public static void Run(){
            Solution(new int[]{10,9,8,7,10,9,8,7}, new int[]{10,9,8,7});
            
        }
        public static int Solution(int[] greedScore, int[] cookies){
            int numChildren = greedScore.Length;
            HashSet<int> set1 = greedScore.ToHashSet();
            HashSet<int> set2 = cookies.ToHashSet();
            set1.Except(set2);
            return numChildren - set1.Count;
        }
    }
}
// @lc code=end

