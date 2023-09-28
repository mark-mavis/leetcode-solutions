/*
 * @lc app=leetcode id=119 lang=csharp
 *
 * [119] Pascal's Triangle II
 */

// @lc code=start
public partial class Easy{  
    public class PascalsTriangleII{
        public static void Run(){
            Solution(5);
        }

        public static IList<int> Solution(int rowIndex){

            // base case 
            if (rowIndex == 0) return new List<int>() { 1 };

            if (rowIndex == 1) return new List<int>() { 1, 1 };

            var lastRow = Solution(rowIndex - 1);

            // current row starts with 1
            List<int> res = new List<int>() { 1 };

            // current row should have 1+lastRow.count
            for (int i = 1; i < lastRow.Count; i++)
            {
                res.Add(lastRow[i - 1] + lastRow[i]);
            }

            // current row ends with 1
            res.Add(1);

            return res;
        }
    }
}
// @lc code=end

