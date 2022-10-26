namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            int i = int.Parse(Console.ReadLine());
            string url = $"https://omdbapi.com/?s={s}&page={i}&apikey=d8c25eb8";

           
            HttpClient client = new HttpClient();

            var response = client.GetAsync(url).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            
            while(true)
            {
                Menu();
                int choose = int.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 0:
                        Console.Clear();
                        Thread.Sleep(1000);
                        return;
                    case 1:
                        Console.Clear();
                        SortedByType(); 
                        break;
                    case 2:
                        Console.Clear();
                        MenuTitle();
                        int choose2 = int.Parse(Console.ReadLine());
                        switch(choose2)
                        {
                            case 0:
                                Console.Clear();
                                Thread.Sleep(1000);
                                return;
                            case 1:
                                Console.Clear();
                                ViewMovies();
                                break;
                            case 2:
                                Console.Clear();
                                ViewSeries();
                                break;
                            case 3:
                                Console.Clear();
                                ViewEpisode();
                                break;
                        }
                        break;
                }
            }
        }
        static void ViewEpisode()
        {

        }
        static void ViewSeries()
        {

        }
        static void ViewMovies()
        {

        }
        static void SortedByType()
        {
            
        }
        static void Menu()
        {
            Console.WriteLine("1: Sort By Type");
            Console.WriteLine("2: Sort By Title");
            Console.WriteLine("0: Exit the Program");
            Console.Write("select a page: ");
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