/*
 * @lc app=leetcode id=1431 lang=csharp
 *
 * [1431] Kids With the Greatest Number of Candies
 */

// @lc code=start
using System.Data;

public partial class Easy {
    public class KidsWithTheGreatestNumberOfCandies{
        public static void Run(){
            IList<bool> result = Solution(new int[]{2,3,5,1,3}, 3);
        }
        public static IList<bool> Solution(int[] candies, int extraCandies) {
            bool[] result = new bool[candies.Length];
            int n = candies.Length;

            int maxStartingCandies = int.MinValue;
            for(int i = 0; i < n; i++){
                if(candies[i] > maxStartingCandies) maxStartingCandies = candies[i];
            }

            for(int i = 0; i < n; i++){
                if((candies[i] + extraCandies) >= maxStartingCandies){
                    result[i] = true;
                }else{
                    result[i] = false;
                }
            }

            return result.ToList();
        }
    }
    
}
// @lc code=end

