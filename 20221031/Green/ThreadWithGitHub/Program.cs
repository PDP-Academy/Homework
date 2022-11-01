namespace Thread;

using System;
using System.Threading;
using System.Threading.Tasks;
class Program
{
    private static List<int> ints = new List<int>();
    static void Main(string[] args)
    {
        MainMenu();
    }

    #region MainMenu
    static void MainMenu()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("1. Task1.");
        System.Console.WriteLine("2. Task2.");
        System.Console.WriteLine("3. Task3.");
        System.Console.WriteLine();
        System.Console.Write("-->  ");
        int change = Convert.ToInt32(Console.ReadLine());

        switch (change)
        {
            case 1: Task1(); break;
            case 2: Task2(); break;
            case 3: Task3(); break;
            default: MainMenu(); break;
        }
    }
    #endregion

    #region Task1
    static void Task1()
    {
        Task[] tasks = new Task[100];

        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(() => TaskMethod(i));

            Thread.Sleep(100);
        }

        Task.WaitAll(tasks);

        MainMenu();
    }
    static void TaskMethod(int id)
    {
        for (int i = 0; i < 1000; i++)
            Console.WriteLine($"Task #{id} {i}");
    }
    #endregion

    #region Task2
    public static void Task2()
    {
        int number = 10;

        System.Console.WriteLine(CreateThread(number));

        MainMenu();
    }
    static Thread CreateThread(int number)
    {
        Thread newThread = new Thread(() => PrintThread(number));
        newThread.Start();
        newThread.Join();

        if (number == 1)
            return null;

        number--;

        return CreateThread(number);
    }
    static void PrintThread(int number)
    {
        System.Console.WriteLine($"{number} - thread.");
    }
    #endregion

    #region Task3
    static void Task3()
    {
        Thread thread = new Thread(AddNumber);
        thread.Start();

        MainMenu();
    }
    static void AddNumber()
    {
        for (int i = 1; i <= 10; i++)
        {
            ints.Add(i);
            Thread thread = new Thread(() => PrintNums(ints));
            thread.Start();
            thread.Join();
        }
    }
    static void PrintNums(List<int> ints)
    {
        System.Console.Write("[");
        for (int i = 0; i < ints.Count; i++)
        {
            if(i != ints.Count - 1)
                System.Console.Write($"{ints[i]}, ");
            else
                System.Console.Write($"{ints[i]}");
        }
        System.Console.WriteLine("]");
    }
    #endregion
}