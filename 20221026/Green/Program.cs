using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Green;

internal class Program
{
    private static void Main(string[] args)
    {
        string url = "https://www.omdbapi.com/?i=tt3896198&apikey=";
        
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

    }
}