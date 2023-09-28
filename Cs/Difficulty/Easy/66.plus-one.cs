/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public partial class Easy {
    public class PlusOne{
        public static void Run(){
            
        }
        public static int[] Solution(int[] digits){
            for(int i = digits.Length-1; i >= 0; i--){
                if(digits[i] == 9){
                    digits[i] = 0;
                }else{
                    digits[i]++;
                    return digits;
                }
            }
            int [] newNumber = new int []{1};
            return newNumber.Concat(digits).ToArray();
        }
    }
}
// @lc code=end

