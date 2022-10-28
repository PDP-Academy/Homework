class Program
{
    static void Main(string[] args)
    {
        #region Largest Element in an Array

        /*
        class Compute
            {

                public int largest(int arr[], int n)
                {
                    n = Integer.MIN_VALUE;
                    for (int i = 0; i< arr.length; i++)
                    {
                        if (arr[i]>n)
                            n = arr[i];
                    }
                    return n;
                }
            }
        */
        #endregion

        #region Second Largest Element in an Array without sorting

        /*
         class Solution {
    int print2largest(int arr[], int n) {
        // code here
        int max = arr[0]; 
        int max1 = -1; 
        for(int i = 0; i < arr.length; i++)
        {
            if(arr[i]>max)
            {
                max = arr[i];
            }
        }
        for(int i = 0; i < arr.length; i++)
        {
            if(arr[i] > max1 && arr[i] != max)
            {
                max1 = arr[i];
            }
        }
        return max1;
    }
}
         */
        #endregion

        #region Check if the array is sorted

        /*
         public class Solution {
    public bool Check(int[] nums) {
        int changes = 0;
        int temp = 0;
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] < nums[i-1])
            {
                changes++;
                if(changes == 2)
                    return false;
                temp = i - 1;
            }
        }
        if(nums[0] > nums[nums.Length - 1] ||
           changes == 0 || 
           nums[0] == nums[nums.Length - 1])
            return true;
        return false;
    }
}
         */

        #endregion
        #region Remove duplicates from Sorted array

        /*
         public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n=1;
        for(int i=0; i<nums.Length-1; i++){
            if(nums[i]==nums[nums.Length-1])
                    break;
            if(nums[i]==nums[i+1]){
                for(int j=i;j<nums.Length-1;j++){
                    nums[j]=nums[j+1];
                }
                i--;
            }else
                n++;
        }
        return n;
    }
}

         */

        #endregion
        #region Left Rotate an array by one place


        #endregion
        #region Left rotate an array by D places



        #endregion
        #region Move Zeros to end

        /*
         public class Solution {
    public void MoveZeroes(int[] nums) {
            int k = 0;
        for(int i=0;i<nums.Length - k;i++)
        {
            if(nums[i]==0)
            {
                 for(int j=i;j<nums.Length - k - 1;j++)
                 {
                     int temp = nums[j];
                     nums[j] = nums[j+1];
                     nums[j+1] = temp;
                 }
                k++;
                i--;
                
            }
            
        }
        
    }
}
         */

        #endregion
        #region Linear Search

        /*
         class Solution{
    static int searchInSorted(int arr[], int N, int K)
    {
        
        // Your code here
        for(int i = 0; i < N; i++ )
        {
            if(arr[i] == K)
            return 1;
        }
        return -1;
    }
}
         */

        #endregion
        #region Find the Union and intersection of two sorted arrays




        #endregion

        #region Find missing number in an array



        #endregion

        #region Maximum Consecutive Ones



        #endregion

        #region Linear Search



        #endregion

        #region Subarray with given sum



        #endregion

        #region Find the Missing Number



        #endregion

        #region Find the number that appears once, and other numbers twice.



        #endregion

        #region Search an element in a 2D matrix



        #endregion

        #region Find the row with maximum number of 1’s



        #endregion
    }
}