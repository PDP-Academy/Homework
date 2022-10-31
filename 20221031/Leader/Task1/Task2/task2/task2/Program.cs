namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecursiveThread(10);
        }

        static void RecursiveThread(int num)
        {
            if(num == 0) return;    
            Thread thread = new Thread(() => Print(num));
            thread.Start();
            thread.Join();

            num--;

            RecursiveThread(num);
        }

        static void Print(int num)
        {
            Console.WriteLine(num);
        }


    }
}