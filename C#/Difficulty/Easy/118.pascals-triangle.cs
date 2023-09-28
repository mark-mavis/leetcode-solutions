/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */
// @lc code=start
public partial class Easy{
    public class PascalsTriangleI{
        public static void Run(){
            PascalsTriangleI.Solution(5);
        }

        public static IList<IList<int>> Solution(int numRows){
            
            if(numRows == 0) return new List<IList<int>>(0);
            
            //Create Instance of triangle
            List<IList<int>> triangle = new List<IList<int>>();
            
            //Add First Row to triangle
            triangle.Add(new List<int>(){1});

            for(int i = 1; i < numRows; i++){
                //Grab the previous row
                List<int> prevRow = (List<int>)triangle[i-1];
                
                //Create new row and add 1 to beginning
                List<int> newRow = new List<int>(){1};
                
                //INTERNAL "SUMS" ITERATOR
                //The Previous row length describes how many internal sums will be created and added to new row
                for(int j = 1; j < prevRow.Count; j++){
                    newRow.Add(prevRow[j - 1] + prevRow[j]);
                }

                //Add last 1 to the new row
                newRow.Add(1);

                //Add the new row to the triangle
                triangle.Add(newRow);
            }

            return triangle;

        }
    }
}
// @lc code=end

