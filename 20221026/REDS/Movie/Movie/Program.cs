namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Filem nomi: ");
                string nameFilm = Console.ReadLine();
                Type();
                string type = Console.ReadLine();
                string url = $"https://omdbapi.com/?s={nameFilm}&type={type}&page=1&page=1&apikey=d8c25eb8";
                int count=10;
                int pasition=1;

                while(pasition<=count/10)
                {
                    url= $"https://omdbapi.com/?s={nameFilm}&type={type}&page={pasition}&page=1&apikey=d8c25eb8";
                   // foreach ()

                    var strelka= Console.ReadKey(false).Key; ;
                    switch( strelka)
                    {
                        case ConsoleKey.RightArrow:

                            if (pasition != count)
                                pasition++;
                            
                            break;
                        case ConsoleKey.LeftArrow:
                            if (pasition != 1)
                                pasition--;
                            break;
                            case

                    }
                    
                }




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
        static void Type()
        {
            Console.WriteLine("movie , series, ");
            Console.Write("Tanlab yozing: ");

        }
    }
}