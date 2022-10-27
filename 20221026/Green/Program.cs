using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Green;

internal class Program
{
    private static void Main(string[] args)
    {
        string url = "http://www.omdbapi.com/?t=ba&plot=full&apikey=";
        
        string myKey = "ca272312";

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url + myKey);

        var response = client.GetAsync(url + myKey).Result;
        var contentString = response.Content.ReadAsStringAsync().Result;

        var option = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
        var movie = JsonSerializer.Deserialize<Movie>(contentString, option);
        Console.WriteLine(movie.Language);
        Console.WriteLine(movie.Title);
        Console.WriteLine(movie.ImdbID);
        Console.WriteLine(movie.Year);
        Console.WriteLine(movie.Director);
        Console.WriteLine(movie.Actors);
        Console.WriteLine(movie.Plot);
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
                break;
            }
            case 2:
            {
                break;
            }
            default:
            {
                break;
            }
        }
    }
    static void SearchToTitle()
    {

    }
}