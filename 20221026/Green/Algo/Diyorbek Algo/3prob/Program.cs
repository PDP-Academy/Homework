
class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1,2,1,1 };
        LinkedList<int> list = new LinkedList<int>();
        

        Console.WriteLine(Check(nums));

    }
    static bool Check(int[] nums)
    {
        int len = nums.Length;
        int min = int.MaxValue, x = 0;

        for (int i = 0; i < len; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
                x = i;
            }
            if (min == nums[i] && i > 0 && nums[i] != nums[i - 1])
            {
                min = nums[i];
                x = i;
            }
        }

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[(i - 1 + x) % len] > nums[(i + x) % len])
                return false;
        }
        return true;
    }
}
