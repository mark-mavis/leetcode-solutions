namespace LeetCodeArray;
using System.Collections.Generic;

public class Easy_Array{

    public class SeachInsertPosition{
        public static int Solution(int[] nums, int target){
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] >= target) return i;
            }
            GC.Collect();
            return nums.Length;
        }
        public static int ImprovedSolution(int[] nums, int target){
            int left = 0;
            int right = nums.Length-1;

            while(left <= right){
                int mid = (right - left)/2;
                if(nums[mid] == target){
                    return mid;
                }else if(nums[mid] < target){
                    left = mid + 1;
                }else{
                    right = mid - 1;
                }
            }
            return left;
        }
    }
    public class PlusOne{
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
    public class MergeSortedArray{
        public static void Solution(int[] nums1, int m, int[] nums2, int n){
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            for(int i = m, j = 0; i < n1 && j < n2; i++, j++){
                nums1[i] = nums2[j];
            }
            Array.Sort(nums1);
        }
        public static void ImprovedSolution(int[] nums1, int m, int[] nums2, int n){
            int nums1Idx = m - 1;   //Setting It to the last element in nums1 array
            int nums2Idx = n - 1;   //Seeting It to the last element in nums2 array
            int combinedIdx = m + n - 1;    //Setting It to the last index in the nums1 array

            while (combinedIdx >= 0)
            {           
                if (nums1Idx < 0 || nums2Idx >= 0 && nums1[nums1Idx] < nums2[nums2Idx])
                {
                    nums1[combinedIdx--] = nums2[nums2Idx--];
                }
                else
                {
                    nums1[combinedIdx--] = nums1[nums1Idx--];
                }
            }
        }
    }
    public class ConvertSortedArray{
        public static HelperObjects.TreeNode SortedArrayToBST(int[] nums) {
            if(nums == null || nums.Length == 0)
                return null;
            return constructBSTRecursive(nums, 0, nums.Length - 1);           
        }

        public static HelperObjects.TreeNode constructBSTRecursive(int[] nums, int left, int right){
            
            if(left > right) return null;
            int midpoint = left + (right - left)/2;
            HelperObjects.TreeNode node = new HelperObjects.TreeNode(nums[midpoint]);
            node.left = constructBSTRecursive(nums, left, midpoint-1);
            node.right = constructBSTRecursive(nums, midpoint+1, right);
            return node;
        }   
    }
    public class PascalsTriangle{
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
    public class PascalsTriangleII{
        public static IList<int> GetRow(int rowIndex){

            // base case 
            if (rowIndex == 0) return new List<int>() { 1 };

            if (rowIndex == 1) return new List<int>() { 1, 1 };

            var lastRow = GetRow(rowIndex - 1);

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
    public class MaxProfit{
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
    public class SingleNumber{
        public static int Solution(int[] nums){
            /*
                Cases: 
                1) No empty arrays.
                2) One Number Array.
                3) Many number arrays
            */
            Array.Sort(nums);
            for(int i = 0; i < nums.Length-1; i+=2){
                if(nums[i] == nums[i+1]){
                    continue;
                }else{
                    return nums[i];
                }
            }
            return nums[nums.Length-1];
        }

        public static int ImprovedSolution(int[] nums){
            var singleNumber = 0;
            foreach(var item in nums)   
            {
                singleNumber ^= item;
            }
            return singleNumber;
        }
    }
    public class MajorityElement{
        public static int MemorySolution(int[] nums){
            int mid = nums.Length/2;
            
            Array.Sort(nums);
            GC.Collect();
            return nums[mid];
        }

        public static int RuntimeSolution(int[] nums){
            Dictionary<int, int> ValueCounts = new Dictionary<int, int>(2);
            foreach(int val in nums){
                if(!ValueCounts.ContainsKey(val)){
                    ValueCounts.Add(val, 1);
                }else{
                    ValueCounts[val]++;
                }
            }
            int maxValue = 0;
            int maxKey = -1;
            foreach(KeyValuePair<int, int> kvp in ValueCounts){
                if(kvp.Value > maxValue){
                    maxValue = kvp.Value;
                    maxKey = kvp.Key;
                }
            }
            return maxKey;

        }
    }
    public class ContainsDuplicate{
        public static bool Solution(int[] nums){
            Dictionary<int, bool> values = new Dictionary<int, bool>();
            foreach(int val in nums){
                if(!values.ContainsKey(val)){
                    values.Add(val, true);
                }else{
                    return values[val];
                }
            }
            return false;
        }
    }
    public class ContainsDuplicateII{
        public static bool Solution(int[] nums, int k){
            Dictionary<int, int> kvp = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++){
                int curVal = nums[i];
                if(!kvp.ContainsKey(curVal)){
                    kvp.Add(curVal, i);
                }else{
                    if( (Math.Abs(kvp[curVal] - i) <= k) && (curVal == nums[kvp[curVal]]) ) return true;
                    else kvp[curVal] = i;
                }
            }
            return false;
        }


    }
    public class SummaryRanges{
        
        //Sorted
        //Unique Integers
        public static IList<string> Solution(int[] nums){
            IList<string> strings = new List<string>();

            if(nums == null || nums.Length == 0){
                return strings;
            }

            int size = nums.Length;
            int start = nums[0];

            for(int i = 0; i < size; i++){
                if(i < size - 1 && nums[i+1] == nums[i] + 1){
                    continue;
                }

                if(nums[i] == start){
                    strings.Add($"{start}");
                }else{
                    strings.Add($"{start}->{nums[i]}");
                }

                //Update start to current i
                if(i < size - 1){
                    start = nums[i+1];
                }
            }
            return strings;



        }
    }
    public class MissingNumber{
        public static int Solution(int[] nums){
            
            int maxVal = 0;
            foreach(int val in nums){
                if(val > maxVal) maxVal = val;
            }
            
            //The missing number is outside of the low and high values given
            if(maxVal == nums.Length-1) return maxVal + 1;
            else{
                decimal sum_dec = (((decimal)nums.Length+1)/2)*(0+maxVal);
                int sum = (int)sum_dec;
                foreach(int val in nums){
                    sum -= val;
                }
                return sum;
            }
        }
    }
    public class MoveZeros{

        public static void Solution(int[] nums){
            if(nums == null || nums.Length == 0){
                return;
            }

            int placementIT = 0;
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] != 0){
                    int temp = nums[placementIT];
                    nums[placementIT] = nums[i];
                    nums[i] = temp;
                    placementIT++;
                }
            }
        }
    }
    public class NumArray {

    private int[] arr;

    public NumArray(int[] nums) {
        arr = nums;
    }
    
    public int SumRange(int left, int right) {
        return arr[left..(right+1)].Sum();
    }
}
    public class IntersectionOfTwoArrays{
        public static int[] Solution(int[] nums1, int[] nums2){
            return nums1.Intersect(nums2).ToArray();
        }

    }
    public class IntersectionOfTwoArraysII{
        public static int[] Solution(int[] nums1, int[] nums2){
            Dictionary<int, int> values = new Dictionary<int, int>();
            foreach(int val in nums1){
                if(!values.ContainsKey(val)){
                    values.Add(val, 1);
                }else{
                    values[val]++;
                }
            }

            List<int> list = new List<int>();

            foreach(int val in nums2){
                if(values.ContainsKey(val)){
                    list.Add(val);
                    values[val]--;
                    if(values[val] == 0) values.Remove(val);
                }
            }

            return list.ToArray();
        }
    }
    public class ThirdMaximumNumber{
        public static int Solution(int[] nums){
            int[] uniqueValues = nums.ToList().Distinct().ToArray();
            if(uniqueValues.Length < 3) return uniqueValues.Max();
            else{
                Array.Sort(uniqueValues);
                Array.Reverse(uniqueValues);
                return uniqueValues[2];
            }
        }
        public static int ImprovedTimeComplexity(int[] nums){
            Array.Sort(nums);
            Array.Reverse(nums);

            int elementCount = 1;
            int prevElement = nums[0];

            for(int i = 0; i < nums.Length; i++){
                if(nums[i] != prevElement){
                    elementCount++;
                    prevElement = nums[i];
                }
                if(elementCount == 3){
                    return nums[i];
                }
            }
            return nums[0];
        }
    }
    public class FindDisappearedNumbers{
        public static IList<int> Solution(int[] nums){
            return Enumerable.Range(1, nums.Length).ToHashSet<int>().Except(nums).ToList();
        }
        public static IList<int> ImprovedSolution(int[] nums){
            int n = nums.Length;
            var result = new List<int>();
            for (int i = 0; i < n; i++) {
                //Grabs the value at the current index, makes it a positive value, the returns it to the outer
                // array indexer-1 to mark that index value negative to show the value that should go there is found
                if (nums[Math.Abs(nums[i])-1] > 0) {
                    nums[Math.Abs(nums[i])-1] *= -1;
                }
            }

            //Iterate through the array and every value that is not negative, that value was not found so add the index value + 1 to a list;
            for (int i = 0; i < n; i++) {
                if (nums[i] > 0) {
                    result.Add(i+1);
                }
            }
            return result;
        }
        public static List<int> ReCodeSolution(int[] nums){
            int n = nums.Length;
            List<int> result = new List<int>();

            for(int i = 0; i < n; i++){
                if(nums[Math.Abs(nums[i])] > 0){    // Pulling out the value at the index and checking the index it should go
                    nums[Math.Abs(nums[i])] *= -1;  // Marking the index that the previous value should be in
                }
            }

            for(int i = 0; i < n; i++){
                if(nums[i] > 0){
                    result.Add(i+1);
                }
            }
            return result;



        }
    }
    public class AssignCookies{
        public static int Solution(int[] greedScore, int[] cookies){
            int numChildren = greedScore.Length;
            HashSet<int> set1 = greedScore.ToHashSet();
            HashSet<int> set2 = cookies.ToHashSet();
            set1.Except(set2);
            return numChildren - set1.Count;
        }
    }
    public class IslandPerimeter{
        public static int Solution(int[][] grid){
            int totalPerimeter = 0;
            int m = grid.Length;
            int n = grid[0].Length;
            for(int i = 0; i < m; i++){
                for(int j = 0; j < n; j++){
                    if(grid[i][j] == 1){
                        int localparameter = 4;
                        //Verticle Checks
                        if((i+1) < m && grid[i+1][j] == 1) localparameter -= 1;
                        if((i-1) >= 0 && grid[i-1][j] == 1) localparameter -= 1;
                        //Horizontal Checks
                        if((j+1) < n && grid[i][j+1] == 1) localparameter -= 1;
                        if((j-1) >= 0 && grid[i][j-1] == 1) localparameter -= 1;

                        totalPerimeter += localparameter;
                    }
                }
            }
            return totalPerimeter;
        }
    }
    public class MaxConsecutiveOnes{
        public static int Solution(int[] nums){
            int maxOneCount = 0;
            int currOneCount = 0;
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] == 1){
                    currOneCount++;
                    if(currOneCount > maxOneCount) maxOneCount = currOneCount;
                    continue;
                }
                currOneCount = 0;
            }
            return maxOneCount;
        }
    }
    public class TeemoAttacking{
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
    public class NextGreaterElement1{
        public static int[] Solution(int[] nums1, int[] nums2){
            //int[] results = new int[nums1.Length];
            Dictionary<int, int> values = nums2.Select((value, index) => new {value, index}).ToDictionary(pair => pair.value, pair => pair.index);
            
            for(int i = 0; i < nums1.Length; i++){
                int curVal = nums1[i];
                int startPos = values[curVal];
                if(startPos+1 < nums2.Length){
                    for(int j = startPos+1; j < nums2.Length; j++){
                        if(nums2[j] > curVal) curVal = nums2[j];
                    }
                    if(curVal == nums1[i]) nums1[i] = -1;
                    else nums1[i] = curVal;
                }else{
                    nums1[i] = -1;
                }

            }
            return nums1;
        }
    }
    public class KeyboardRow{
        public static string[] Solution(string[] words){
            List<string> result = new List<string>();
            foreach(string str in words){
               if(CheckRows(str)){
                result.Add(str);
               }
            }
            return result.ToArray<string>();
        }
        private static bool CheckRows(string word){
            bool tRowResult = true;
            bool mRowResult = true;
            bool bRowResult = true;
            
            string tRow = "qwertyuiopQWERTYUIOP";
            string mRow = "asdfghjklASDFGHJKL";
            string bRow = "zxcvbnmZXCVBNM";
            
            foreach(char ch in word){
                if(!tRow.Contains(ch)) tRowResult = false;
                if(!mRow.Contains(ch)) mRowResult = false;
                if(!bRow.Contains(ch)) bRowResult = false;

                if(!(tRowResult || mRowResult || bRowResult)){
                    return false;
                }
            }
            return tRowResult || mRowResult || bRowResult;
        }
    }
    public class RelativeRanks{
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
    public class ArrayPartition{
        public static int Solution(int[] nums){
            int n = nums.Length;
            int sum = 0;
            Array.Sort(nums);
            for(int i = 0; i < n; i = i+2){
                sum += nums[i];
            }

            return sum;
        }
    }
    public class ReshapeTheMatrix{
        public static int[][] Solution(int[][] mat, int r, int c){
            
            int n = mat.Length;
            int m = mat[0].Length;
            
            if (m * n != r * c) {
                return mat;
            }
            
            int[][] arr = new int[r][];
            for (int i = 0; i < r; i++) {
                arr[i] = new int[c];
            }
            
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    int l = i * m + j;
                    arr[l / c][l % c] = mat[i][j];
                }
            }
            
            return arr;
        }
    }

    //------------------------------------------------------------------
    // PALINDROME NUMBER

    public static bool IsPalindrome(int x){
        string strValue = x.ToString();

        int start = 0;
        int end = strValue.Length-1;

        bool isPalindromeFlag = true;

        while(start <= end){
            if(strValue[start] != strValue[end]) isPalindromeFlag = false;
        }
        return isPalindromeFlag;
    }





}
