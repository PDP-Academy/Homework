using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Green;

internal class Program
{
    private static void Main(string[] args)
    {
        string url = "https://www.omdbapi.com/?s=Batman&page=2&apikey=";
        
        string myKey = "ca272312";

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url + myKey);

        var response = client.GetAsync(url + myKey).Result;
        var contentString = response.Content.ReadAsStringAsync().Result;

        var option = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
        var movie = JsonSerializer.Deserialize<Search>(contentString, option);

        var moviesList = movie.Movies;

        foreach (var item in moviesList)
        {
            Console.WriteLine(item.Title);
        }
    }

    static void MainMenu()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("1.Title bo'yicha qidirish");
        System.Console.WriteLine("1.Toifa bo'yicha qidirish");
    }
    static void SearchToTitle()
    {
       
    }
}