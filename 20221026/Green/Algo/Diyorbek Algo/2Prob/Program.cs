internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 4, 23, 45, 24 };

        Console.WriteLine(Print2Largest(arr));
    }

    static int Print2Largest(int[] arr)
    {
        int max = int.MinValue, second = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                second = max;
                max = arr[i];
            }
            else if (arr[i] > second)
                second = arr[i];
        }

        return second;
    }
}