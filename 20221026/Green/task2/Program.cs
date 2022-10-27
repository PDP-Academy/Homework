using System;
using System.Text.Json;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;
namespace task2;

class Program
{
    static void Main(string[] args)
    {
        SearchByName();
        // WallStreetJournal();
        Menu1();
    }




    static void SearchByName()
    {
        Console.Write("Value kiriting: ");
        string name = Console.ReadLine();
        string url = $@"https://newsapi.org/v2/everything?q={name}&apiKey=e20df51e594a4b7daae76ca0ce171f4e";
        HttpClient client = new HttpClient();
        var response = client.GetAsync(url).Result;
        var content = response.Content.ReadAsStringAsync().Result;
        var json = JsonSerializer.Deserialize<Root>(content, new JsonSerializerOptions() {PropertyNameCaseInsensitive = true });
        int pagenation = 10;
        int i = 0;
        Console.WriteLine(url);
        while (true)
        {
            Console.Clear();
            for (; i < pagenation && i < json.totalResults; i++)
            {
                Console.WriteLine($"{i + 1}. {json.articles[i].title}");
            }
            Console.WriteLine($@"<<{i / 10} - {json.totalResults / 10}>>");
            var key = Console.ReadKey().Key;
            if (pagenation == 0 || pagenation == 1 && key == ConsoleKey.LeftArrow)
                continue;
            if (pagenation == json.totalResults / 10 && ConsoleKey.RightArrow == key)
                continue;
            if (ConsoleKey.LeftArrow == key)
            {
                i -= 20;
                pagenation -= 10;
            }
            if (ConsoleKey.RightArrow == key)
            {
                i = pagenation;
                pagenation += 10;
            }

            if (ConsoleKey.Escape == key)
                return;
            
        }

    }
    static void Menu1()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("1.All sources.");
        System.Console.WriteLine("2.By category.");
        System.Console.WriteLine("3.By lenguage.");
        System.Console.WriteLine("4.By country.");
        System.Console.WriteLine();
        System.Console.Write("-->  ");
        int change = Convert.ToInt32(Console.ReadLine());

        switch (change)
        {
            case 1:
            {
                ByCategory();
                Menu1();
            } break;
            case 2:
            {

            } break;
            case 3:
            {

            } break;
            case 4:
            {

            } break;

            default:
            {

            } break;
        }
    }
    static void ByCategory()
    {
        string url = "https://newsapi.org/v2/top-headlines/sources?";

        string apiKey = "apiKey=ebfcc5d8f7b745f78205156776824331";

        System.Console.WriteLine("1. Business.");
        System.Console.WriteLine("2.Entertainment.");
        System.Console.WriteLine("3.General.");
        System.Console.WriteLine("4.Health.");
        System.Console.WriteLine("5.Scince.");
        System.Console.WriteLine("6.Sports.");
        System.Console.WriteLine("7.Technology.");
        System.Console.WriteLine();
        System.Console.WriteLine("-->  ");
        int change = Convert.ToInt32(Console.ReadLine());

        string category = "";
        switch (change)
        {
            case 1:
            {
                category = "category=business";
            } break;
            case 2:
            {
                category += "category=entertainment";
            } break;
            case 3:
            {
                category += "category=general";
            } break;
            case 4:
            {
                category += "category=health";
            } break;
            case 5:
            {
                category += "category=science";
            } break;
            case 6:
            {
                category += "category=sports";
            } break;
            case 7:
            {
                category += "category=technology";
            } break;

            default:
            break;
        }

        string newUrl = url + category + apiKey;

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(newUrl);

        var response = client.GetAsync(newUrl).Result;

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

            var change2 = Console.ReadKey().Key;

            if (change2 == ConsoleKey.RightArrow)
                i++;
            else if (change2 == ConsoleKey.LeftArrow && i != 0)
                i--;
            else if (change2 == ConsoleKey.Backspace)
                return;

            Console.Clear();
        }

    }
    static void WallStreetJournal()
    {
        System.Console.WriteLine("\tOxirgi 6 oy ichida Wall Street Journal tomonidan chop etilgan barcha maqolalar,\n\tso'nggi birinchisi bo'yicha saralangan!\n");

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

            if (change == ConsoleKey.RightArrow && i < result - 1)
                i++;
            else if (change == ConsoleKey.LeftArrow && i != 0)
                i--;
            else if (change == ConsoleKey.Backspace)
                return;

            Console.Clear();
        }
    }
}