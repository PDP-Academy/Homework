using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Green;

internal class Program
{
    private static void Main(string[] args)
    {
        string url = "https://www.omdbapi.com/?t=Bn&page=&apikey=";
        
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
        System.Console.WriteLine();
        System.Console.WriteLine("1.Title bo'yicha qidirish");
        System.Console.WriteLine("2.Toifa bo'yicha qidirish");
        System.Console.WriteLine();
        System.Console.Write("-->  ");

        int change = Convert.ToInt32(Console.ReadLine());

        switch (change)
        {
            case 1:
            {
                    SearchByTitle();       
            } break;

            case 2:
            {

            } break;

            default:
            {

            } break;
        }
    }
    static void SearchByTitle()
    {
        string url = "https://www.omdbapi.com/?";
        string title = "s=";
        string pageStr = "&page=";
        string myKey = "&apikey=ca272312";
        int index = 1;

        Console.Write("title: ");
        title += Console.ReadLine();


        while (true)
        {
            string newUrl = url + title + pageStr + $"{index}" + myKey;

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(newUrl);

            var response = client.GetAsync(newUrl).Result;
            var contentString = response.Content.ReadAsStringAsync().Result;

            var option = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            var search = JsonSerializer.Deserialize<Search>(contentString, option);

            var moviesList = search.Movies;

            foreach (var item in moviesList)
            {
                Console.WriteLine("Title: " + item.Title);
            }
            Console.WriteLine("Page: " + index);

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow)
            {
                index++;
            }
            else if (change == ConsoleKey.LeftArrow)
            {
                index--;
            }
            Console.Clear();
        }
    }
    static void SortedToType()
    {
        string url = "https://www.omdbapi.com/?";
        
        List<Movie> movies = new List<Movie>();
        List<Movie> series = new List<Movie>();
        List<Movie> episode = new List<Movie>();
    }
}