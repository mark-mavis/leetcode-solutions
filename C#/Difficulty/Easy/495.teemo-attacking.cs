/*
 * @lc app=leetcode id=495 lang=csharp
 *
 * [495] Teemo Attacking
 */

// @lc code=start
public partial class Easy{  
    public class TeemoAttacking{
        public static void Run(){
            int result = Solution(new int[]{1, 2}, 2);
        }
        public static int Solution(int[] timeSeries, int duration){
            int poisonT = 0;
            for(int i = 1; i < timeSeries.Length; i++){
                int timeInterval = timeSeries[i] - timeSeries[i-1];
                if(timeInterval > duration){
                    poisonT += duration;
                }else{
                    poisonT += timeInterval;
                }
            }
            poisonT += duration;
            Console.WriteLine($"Returning {poisonT}");
            return poisonT;
        }  
            
    }
}
// @lc code=end

