/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public partial class Easy{  
    public class BestTimeToBuyAndSellStock{
        public static void Run(){
            BruteForce(new int[]{1,2});
            ImprovedSolution(new int[]{7,1,5,3,6,4});
        }
        public static int BruteForce(int[] prices){
            int minValue = 0;
            for(int i = 0; i < prices.Length-1; i++){
                for(int j = i+1; j < prices.Length; j++){
                    int delta = prices[i] - prices[j];
                    if(delta < minValue){
                        minValue = delta;
                    }
                }
            }
            return Math.Abs(minValue);
        }
        
        public static int ImprovedSolution(int[] prices){
            int maxProfit = 0;
            int minStockPrice = prices[0];  //Grab First Stock Price

            for(int day = 1; day < prices.Length; day++){

                if(prices[day] < minStockPrice){
                    minStockPrice = prices[day];
                }else{
                    int currProfit = prices[day] - minStockPrice;
                    if(currProfit > maxProfit){
                        maxProfit = currProfit;
                    }
                }
            }
            return maxProfit;
        }
    }
}
// @lc code=end

