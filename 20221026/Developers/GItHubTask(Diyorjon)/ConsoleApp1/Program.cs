

#region  //Given an array, we have to find the largest element in the array.
//int[] arr = { 2,5,1,3,0};
//int max = arr[0];
//for(int i=0;i<arr.Length;i++)
//{
//    if (max < arr[i])
//        max = arr[i];
//}
//Console.WriteLine(max);
#endregion

#region  //Second Largest Element in an Array without sorting
//int[] number = { 1, 2, 4, 6, 6, 5 };
//int maxmax=int.MinValue; //1
//int max = int.MinValue; //2
//int minmin=int.MaxValue; //1
//int min=int.MaxValue; //2

//if (number.Length < 2)
//{
//    min=-1;
//    max = -1;
//}

//    for (int i = 0; i < number.Length; i++)
//    {
//        if(number[i] < minmin)
//        {
//        min = minmin;
//        minmin=number[i];
//        }
//        else if (number[i] <min)
//        min=number[i];

//    if (number[i] >maxmax)
//        {
//        max=maxmax;
//        maxmax=number[i];
//        }
//        else if (number[i] >max && number[i]!= maxmax )
//        max=number[i];


//}
//Console.WriteLine(min);
//Console.WriteLine(max);
#endregion

#region //1752. Check if Array Is Sorted and Rotated
//static bool Check(int[] nums)
//{

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (i <= nums.Length - 2 && nums[i] > nums[i + 1])
//        {
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (j <= nums.Length - 2 && nums[j] <= nums[j + 1] && nums[nums.Length - 1] <= nums[0] && nums[i] >= nums[j + 1])
//                    if (j == nums.Length - 2)
//                        return true;
//                    else
//                        continue;
//                else if (j == nums.Length - 1 && nums[j] <= nums[0])
//                    return true;
//                else return false;


//            }

//        }

//    }
//    return true;
//}
#endregion

#region //26. Remove Duplicates from Sorted Array
//int[]nums={0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
//RemoveDuplicates(nums);

//static int RemoveDuplicates(int[] nums)
//{
//    int k = 1;
//    int left = 0;
//    int right = 0;
//    while (right <= nums.Length)
//    {
//        if (right <= nums.Length - 1 && nums[left] < nums[right])
//        {
//            nums[left + 1] = nums[right];
//            left++;
//            right = left;
//            k++;
//        }
//        else
//        {
//            right++;
//        }
//    }

//    return k;
//}

#endregion

#region // 189. Rotate Array

//int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
//int k = 3;
//Rotate(nums, k);
//static void Rotate(int[] nums, int k)
//{

//    List<int> number = new List<int>();
//    for (int i = nums.Length - k; i < nums.Length; i++)
//        number.Add(nums[i]);



//    if (nums.Length % 2 == 0)
//        for (int i = 0; i < k; i++)
//            number.Add(nums[i]);


//    else
//        for (int i = 0; i <= k; i++)
//            number.Add(nums[i]);


//    number.CopyTo(nums);


//}

#endregion

#region //283. Move Zeroes

//static void MoveZeroes(int[] nums)
//{
//    int right = 0;
//    int left = 0;
//    while (right < nums.Length)
//    {

//        if (nums[left] != 0)
//        {
//            left++;
//            right = left;
//        }
//        else if (nums[left] == 0 && nums[right] != 0)
//        {
//            int temp = nums[right];
//            nums[right] = nums[left];
//            nums[left] = temp;
//            left++;
//            right = left;

//        }
//        else
//        {
//            right++;

//        }
//    }
//}


#endregion

#region //268. Missing Number

//static int MissingNumber(int[] nums)
//{
//    int number = nums.Length;
//    Dictionary<int, int> available = new Dictionary<int, int>();
//    for (int i = 0; i < nums.Length; i++)
//    {
//        available.Add(nums[i], nums[i]);
//    }
//    int answer = 0;
//    for (int i = 0; i <= number; i++)
//    {
//        if (!available.ContainsKey(i))
//            answer = i;
//    }
//    return answer;
//}

#endregion

#region //485. Max Consecutive Ones
//static int FindMaxConsecutiveOnes(int[] nums)
//{
//    int count = 0;
//    int max = 0;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] == 1)
//        {
//            count++;
//        }
//        else
//        {
//            count = 0;
//        }
//        max = Math.Max(max, count);

//    }
//    return max;
//}
#endregion
