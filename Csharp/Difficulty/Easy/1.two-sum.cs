/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start

namespace Csharp.Difficulty.Easy;

public partial class Easy {
    public class TwoSum{
        public static void Run(){
            Solution(new int[]{2,7,11,15}, 9);
            BruteForce(new int[]{2, 3, 5, 7, 10, 21, 25}, 12);
            Improved(new int[]{2, 3, 5, 7, 10, 21, 25}, 12);
            Optimal(new int[]{2, 3, 5, 7, 10, 21, 25}, 14);
        }

        public static int[] Solution(int[] nums, int target) {
            Dictionary<int, int> lookup = new();
            for(int i = 0; i < nums.Length; i++){
                if(lookup.ContainsKey(nums[i])){
                    GC.Collect();
                    return new int[]{i, lookup[nums[i]]};
                }
                lookup[target-nums[i]] = i;
            }
            return new int[]{-1, -1};
        }

        public static int[] BruteForce(int[] nums, int target){
            /*
                Time Complexity - O(n^2)
                    - Nested for loops
                Space Complexity - O(1)
                    - No auxilary storage needed
            */
            for(int i = 0; i < nums.Length-1; i++){
                for(int j = i+1; j < nums.Length; j++){
                    if(nums[i] + nums[j] == target) {
                        Console.WriteLine($"Returning {nums[i]}, {nums[j]}");
                        return new int[]{nums[i], nums[j]};
                    }
                }
            }
            Console.WriteLine("Returning blank array");
            return Array.Empty<int>();
        }

        public static int[] Improved(int[] nums, int target){
            /*
                Time Complexity = O(N)
                    - Only need to go through the array once because we pull out values we are looking for as we go
                Space Complexity = O(N)
                    - Worst case scenario is that we add search elements for every element in the array to the dictionary
            */
            Dictionary<int, int> lookup = new();
            for(int i = 0; i < nums.Length; i++){
                if(lookup.ContainsKey(nums[i])){
                    return new int[]{i, lookup[nums[i]]};
                }
                lookup.Add(target-nums[i], i);
            }
            return Array.Empty<int>();
        }

        public static int[] Optimal(int[] nums, int target){
            /*
                Time complexity = O(N)
                    - Worst case, we go through every element in the array by working from the left and right outside to the middle
                Space complexity = O(1)
                    - No auxilary space needed to store search elements
            */
            Array.Sort(nums);

            int start = 0;
            int end = nums.Length-1;

            while(start < end){
                int found = nums[start] + nums[end];
                if(found > target){
                    end--;
                }else if(found < target){
                    start++;
                }else{
                    Console.WriteLine($"Returning {nums[start]}, {nums[end]}");
                    return new int[]{nums[start], nums[end]};
                }
            }
            Console.WriteLine("Returing blank array");
            return Array.Empty<int>();
        }
    }
}
    
    

// @lc code=end

