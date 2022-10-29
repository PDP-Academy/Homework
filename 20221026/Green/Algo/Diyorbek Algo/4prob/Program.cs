internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        Console.WriteLine(RemoveDuplicates(arr));
    }
    static int RemoveDuplicates(int[] nums)
    {
        int temp = 101, j = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != temp)
            {
                nums[j++] = nums[i];
                temp = nums[i];
            }
        }
        return j;
    }
}