using System;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace task2;

class Program
{
    static void Main(string[] args)
    {
        WallStreetJournal();
    }

    static void SearchByName(string name)
    {

    }
    static void WallStreetJournal()
    {
        System.Console.WriteLine("Oxirgi 6 oy ichida Wall Street Journal tomonidan chop etilgan barcha maqolalar,\nso'nggi birinchisi bo'yicha saralangan!");

        string url = "https://newsapi.org/v2/everything?domains=wsj.com&apiKey=ebfcc5d8f7b745f78205156776824331";

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url);

        var response = client.GetAsync(url).Result;

        string contentString = response.Content.ReadAsStringAsync().Result;

        var option = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

        var root = JsonSerializer.Deserialize<Root>(contentString, option);

        int result = root.totalResults;

        for (int i = 0; i < result;)
        {
            System.Console.WriteLine("Author: " + root.articles[i].author);
            System.Console.WriteLine("content: " + root.articles[i].content);
            System.Console.WriteLine("description: " + root.articles[i].description);
            System.Console.WriteLine("publishedAt: " + root.articles[i].publishedAt);
            System.Console.WriteLine("ID: " + root.articles[i].source.id);
            System.Console.WriteLine("Name: " + root.articles[i].source.name);
            System.Console.WriteLine("Title: " + root.articles[i].title);
            System.Console.WriteLine("Url: " + root.articles[i].url);
            System.Console.WriteLine("UrlToImage: " + root.articles[i].urlToImage);
            System.Console.WriteLine();
            System.Console.WriteLine($"{i + 1} / {result}");

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow)
                i++;
            else if (change == ConsoleKey.LeftArrow && i != 0)
                i--;
            else if (change == ConsoleKey.Backspace)
                return;

            Console.Clear();
        }
    }
}