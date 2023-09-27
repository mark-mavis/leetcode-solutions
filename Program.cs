
using LeetCode.TopInterview150;
using LeetCodeArray;

class Program
{
    public static void Main()
    {
        //int[] testArray = new int[] { 3, 2, 2, 3 };
        //RemoveElement(testArray, 3);

        //Console.WriteLine(ClimbStairs(44));


        //ArrayController.Run();
        MediumController.Run();
        //Console.ReadLine();
        //MergeSortedArray.Controller();
        //LeetCode.TopInterview150.RemoveElement.Run();

    }

    public static int PeakIndexInMountain(int[] arr){
        //BINARY SEARCH
        int left = 0, right = arr.Length, mid;
        
        // Loop until the left and right indexes are reduced to equal each other
        while(left < right){
            
            // Calculate the middle index
            mid = arr.Length/2;

            if(arr[mid] < arr[mid+1]){
                // If the middle index value is less then the index value to the right
                // update the left index to the middle index+1
                left = mid+1;   
            }else{
                // If the middle index value is greater than the index value to the right
                // update the right index to the middle index
                right = mid;
            }
        }
        GC.Collect();
        return left;
    }
    public static int ClimbStairs(int n)
    {
        int a = 0, b = 1;
        for (int i = 2; i < n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
    public static int RemoveElement(int[] nums, int val)
    {
        int count = 0;
        int start = 0;
        int end = nums.Length - 1;

        while (start <= end)
        {
            if (nums[start] == val && nums[end] != val)
            {
                Swap(nums, start, end);
                end--;
            }
            else if (nums[start] == val && nums[end] == val)
            {
                end--;
            }
            else if (nums[start] != val)
            {
                count++;
                start++;
            }
        }
        return count;
    }
    public static void Swap(int[] arr, int idx1, int idx2)
    {
        int temp = arr[idx1];
        arr[idx1] = arr[idx2];
        arr[idx2] = temp;
    }
}