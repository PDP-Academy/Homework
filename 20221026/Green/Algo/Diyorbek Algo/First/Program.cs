internal class Program
{
    private static void Main(string[] args)
    {
        // Largest Element in Array
        int[] arr = new int[]{ 1, 2, 3, 1000, 5, 690 };

        System.Console.WriteLine(Largest(arr));
        

    }
    static int Largest(int[] arr){

        int max = int.MinValue;

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }
}