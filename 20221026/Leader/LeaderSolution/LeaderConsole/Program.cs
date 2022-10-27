using static System.Net.WebRequestMethods;
using System.Net.Http;
using System.Text.Json;

namespace LeaderConsole;
public class Prgram
{
    static string url = "http://www.omdbapi.com/?";
    static string key = "apikey=d38abc50";
    static void Main(string[] args)
    { 

    }   

    static void Menu()
    {
        Console.WriteLine("1.Type bo'yicha saralash\n" +
            "2.Title bo'yicha qidirish\n" +
            "Any number.Exit");

        int key = int.Parse(Console.ReadLine());

        switch(key)
        {
            case 1:
                SortByType();
                break;
            case 2:
                SearchByTitle();
                break;
            default:
                return;
        }
    }

    static void SearchByTitle()
    {
        Console.Write("Title : ");
        string title = Console.ReadLine();
        string urlForSearch = url + "s=" + title + "&" + key;



    }

    static void SortByType()
    {
        List<RootSort> rootSorts = new List<RootSort>();
        List<string> types = new List<string>()
        {
            "movie",
            "game",
            "serial"
        };

        for(int i = 0; i < types.Count; i++)
        {
            string urlForSearch = url + "t=" + types[i] + "&" + key;

            HttpClient client = new HttpClient();

            var response = client.GetAsync(urlForSearch).Result;

            var contentString = response.Content.ReadAsStringAsync().Result;

            var serializationOption = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            RootSort rootSort = JsonSerializer.Deserialize<RootSort>(contentString, serializationOption);

            rootSorts.Add(rootSort);

            while(true)
            {
                Console.WriteLine(String.Format(" {0,}"))
            }
        }

    }
} 