namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
        }


        }


        static void MenuTitle()
        {
            Console.WriteLine("1: View list of Movies"); // kinolar ro'yhatini ko'rish
            Console.WriteLine("2: View list of Series"); // seriallar ro'yhatini ko'rish
            Console.WriteLine("3: View list of Episode"); // episodelar ro'yhatini ko'rish
            Console.WriteLine("0: Exit the Program");
            Console.Write("select a page: ");
        }
    }
}