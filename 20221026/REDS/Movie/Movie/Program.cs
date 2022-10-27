using Movies;
using System.Text.Json;

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
                int nameTypePosition = int.Parse(Console.ReadLine());
                string nameType;
                if (nameTypePosition == 1)
                    nameType = "movie";
                if (nameTypePosition == 2)
                    nameType = "series";
                else
                    nameType = "episode";

                
                string url ;
            
                int count=100;
                int pasition=1;

                while(pasition<=count/10)
                {
                    url= $"https://omdbapi.com/?s={nameFilm}&type={nameType}&page={pasition}&apikey=d8c25eb8";
                    Search search = GetSearchByUrl(url);
                    foreach (var item in search.Movie)
                    {
                        Console.WriteLine(item);
                    }

                    var strelka= Console.ReadKey(false).Key;
                    Console.Clear();
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
                        case ConsoleKey.UpArrow:
                            pasition = count / 10 + 1;
                            break;

                    }                    
                }
            }
        }
        

        private static Search GetSearchByUrl(string url)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var search = JsonSerializer.Deserialize<Search>(json, new JsonSerializerOptions()
            { 
                PropertyNameCaseInsensitive=true
            });
            return search;
        }
       
        static void Type()
        {
            Console.WriteLine("1.movie \n2.series \n3.episode");
            Console.Write("Tanlab yozing: ");

        }
    }
}