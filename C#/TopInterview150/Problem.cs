using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.TopInterview150
{
    public class MergeSortedArray
    {
        public static void Controller(){
            int[] array1 = new int[]{1, 2, 3, 0, 0, 0};
            int[] array2 = new int[]{2, 5, 6};
            Merge(array1, 3, array2, 3);
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n){

            int j = 0;
            for(int i = m; i < nums1.Length; i++){
                nums1[i] = nums2[j];
                j++;
            }
            Array.Sort(nums1);
        }
    }

    public class RemoveElement{
        public static void Run(){
            int[] array = new int[]{3, 2, 2, 3};
            int result = Solution(array, 3);
            Console.WriteLine(result);
        }
        public static int Solution(int[] nums, int val){
            
            int startIt = 0;
            int endIt = nums.Length-1;
            int count = 0;

            while(startIt < endIt){
                if(nums[endIt] == val) endIt--;
                else{
                    if(nums[startIt] == val){
                        int temp = nums[endIt];
                        nums[endIt] = nums[startIt];
                        nums[startIt] = temp;
                        count++;
                        endIt--;
                        startIt++;
                    }else{
                        startIt++;
                        count++;
                    }
                }
            }
            return count;
        }
    }
}