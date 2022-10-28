using static System.Net.WebRequestMethods;
using System.Net.Http;
using System.Text.Json;

namespace LeaderConsole;
public class Prgram
{
    

    private static void Main(string[] args)
    {
        string url = "https://www.omdbapi.com/?t=Bn&&apikey=";

        string myKey = "ca272312";

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url + myKey);

        var response = client.GetAsync(url + myKey).Result;
        var contentString = response.Content.ReadAsStringAsync().Result;

        var option = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true 
        };

        MainMenu();

    }

    static void MainMenu()
    {

        Console.WriteLine("\n\t1.Title bo'yicha qidirish");
        Console.WriteLine("\t2.Toifa bo'yicha qidirish\n");
        
        Console.Write("-->  ");

        int change = Convert.ToInt32(Console.ReadLine());

        switch (change)
        {
            case 1:
                {
                    SearchByTitle();
                }
                break;

            case 2:
                {

                }
                break;

            default:
                {

                }
                break;
        }
    }
    static void SearchByTitle()
    {
        string url = "https://www.omdbapi.com/?";
        string title = "s=";
        string pageStr = "&page=";
        string myKey = "&apikey=ca272312";
        int index = 1;

        Api managerAPI = new Api();

        Console.Write("title: ");
        title += Console.ReadLine();
        int pages = 10;

        while (index <= pages / 10 && index > 0)
        {
            string newUrl = url + title + pageStr + $"{index}" + myKey;
            string contentString = managerAPI.GetContentString(newUrl);

            var option = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            var search = JsonSerializer.Deserialize<Search>(contentString, option);

            var moviesList = search.Movies;
            pages = int.Parse(search.TotalResults);

            foreach (var item in moviesList)
            {
                Console.WriteLine("  Title: " + item.Title);
            }
            Console.Write($"\t{index}/{pages / 10}");

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow)
                index++;
            else if (change == ConsoleKey.LeftArrow)
                index--;

            Console.Clear();
        }
    }
    static void SortedToType()
    {
        string url = "https://www.omdbapi.com/?";
        string title = "s=";
        string type = "type=";
        string pageStr = "&page=";
        string myKey = "&apikey=ca272312";

        List<Movie> movies = new List<Movie>();
        Api managerAPI = new Api();

        Console.Write("title: ");
        title += Console.ReadLine();
        Console.WriteLine("1.Movie");
        Console.WriteLine("2.");



    }
}