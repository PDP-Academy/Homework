using System;
using System.Text.Json;
namespace task2;

class Program
{
    static void Main(string[] args)
    {
        SearchByName();
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
            for (; i < pagenation && i < json.TotalResults; i++)
            {
                Console.WriteLine($"{i + 1}. {json.Articles[i].title}");
            }
            Console.WriteLine($@"<<{pagenation / 10} - {json.TotalResults / 10}>>");
            var key = Console.ReadKey().Key;
            if (pagenation == 1 && key == ConsoleKey.LeftArrow)
                continue;
            if (pagenation == json.TotalResults / 10 && ConsoleKey.RightArrow == key)
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
}