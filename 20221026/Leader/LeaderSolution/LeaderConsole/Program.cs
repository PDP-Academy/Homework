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
        Menu();
    }   

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1.Random kino olish\n" +
            "2.Title bo'yicha qidirish\n" +
            "Any number.Exit");

        int key = Convert.ToInt32(Console.ReadLine());

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
        Console.Clear();
        Console.Write("Title : ");
        string title = Console.ReadLine();
        Console.Clear();

        int i = 1;
        while (true)
        {
            string urlForSearch = url + "s=" + title + "&" + "page=" + i + "&" + key;

            HttpClient client = new HttpClient();

            var response = client.GetAsync(urlForSearch).Result;

            var contentString = response.Content.ReadAsStringAsync().Result;

            var serializationOption = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            RootSearch rootSearch = JsonSerializer.Deserialize<RootSearch>(contentString, serializationOption);

            Console.WriteLine($"============================================================ {i} ===============================================================\n");
            Console.WriteLine(String.Format("{0,15}|{1,10}|{2,95}|", "Total result", "Response", "Information of Search"));

           
            Console.WriteLine(String.Format("{0,15}|{1,10}|{2,95}|", rootSearch.totalResults,rootSearch.Response, String.Format("{0,10}|{1,10}|{2,10}|{3,10}", "Title","imdbID","Year", "Type")));
        
            foreach(var search in rootSearch.Search)
            {
                Console.WriteLine(String.Format("{0,15}|{1,10}|{2,95}|", "", "", String.Format("{0,10}|{1,10}|{2,10}|{3,10}", search.Title, search.imdbID, search.Year,search.Type)));
            }
            

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow)
                i++;
            else if (change == ConsoleKey.LeftArrow && i - 1 > 0)
                i--;
            else if (change == ConsoleKey.Backspace)
                Menu();
            Console.Clear();

        }
    }
    static void SortByType()
    {

        Console.Write("Title : ");
        string series = Console.ReadLine();
        int i = 1;
        while (true)
        {
            string urlForSearch = url + "&page=" + i + "&t=" + series + "&"  + key;
            Console.WriteLine(urlForSearch);

            HttpClient client = new HttpClient();

            var response = client.GetAsync(urlForSearch).Result;

            var contentString = response.Content.ReadAsStringAsync().Result;

            var serializationOption = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            RootSort rootSort = JsonSerializer.Deserialize<RootSort>(contentString, serializationOption);

            Console.WriteLine(String.Format("{0,28}|{1,10}|{2,30}|{3,30}|{4,25}|{5,35}|{6,10}|{7,10}|{8,10}|", "Title", "Year", "Genre", "Director", "Language", "Country", "Type", "Production", "Responce"));
               
            Console.WriteLine(rootSort.ToString());

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow )
                i++;
            else if (change == ConsoleKey.LeftArrow && i - 1 > 0)
                i--;
            else if (change == ConsoleKey.Backspace)
                Menu();
            Console.Clear();
            
        }

    }
} 