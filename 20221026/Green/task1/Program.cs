using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Green;
using Task1;

internal class Program
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
        System.Console.WriteLine();
        System.Console.WriteLine("1.Title bo'yicha qidirish");
        System.Console.WriteLine("2.Toifa bo'yicha saralash");
 
        System.Console.Write("-->  ");

        int change = 0;
        try
        {
            change = Convert.ToInt32(Console.ReadLine());
        } catch (FormatException exception)
        {
            Console.Clear();
            Console.WriteLine(exception.Message);
            MainMenu();
        }

        switch (change)
        {
            case 1:
                {
                    SearchByTitle();
                }
                break;

            case 2:
                {
                    SortedToType();
                }
                break;

            default:
                {
                    Console.Clear();
                    MainMenu();
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

        IManagerAPI managerAPI = new ManagerAPI();

        Console.Write("\ntitle: ");
        string searchTitle = Console.ReadLine();
        title += searchTitle;
        int pages = 1;

        while (index <= pages && index >= 0)
        {
            Console.WriteLine(" == Search results for " + searchTitle + " == \n");
            string newUrl = url + title + pageStr + $"{index}" + myKey;
            string contentString = managerAPI.GetContentString(newUrl);

            var option = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            var search = JsonSerializer.Deserialize<Search>(contentString, option);
            if (bool.Parse(search.Response) is false )
            {
                Console.Clear();
                Console.WriteLine($"Response: {search.Response} , Error: {search.Error}");
                SearchByTitle();
            }

            var moviesList = search.Movies;
            pages = int.Parse(search.TotalResults) / 10 + 1;

            foreach (var item in moviesList)
            {
                Console.WriteLine("  Title: " + item.Title + " , Year: " + item.Year);
            }
            Console.WriteLine($"\t{index}/{pages}");
            Console.WriteLine("Return to menu: backspace");
            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow && index < pages)
                index++;
            else if (change == ConsoleKey.LeftArrow && index > 1)
                index--;
            else if (change == ConsoleKey.Backspace)
                MainMenu();

            Console.Clear();
        }
        Console.Clear();
        MainMenu();
    }
    static void SortedToType()
    {
        string url = "https://www.omdbapi.com/?";
        string title = "s=";
        string type = "type=";
        string pageStr = "&page=";
        string myKey = "&apikey=ca272312";
        int index = 1;

        List<Movie> moviesSort = new List<Movie>();
        List<Movie> series = new List<Movie>();
        List<Movie> episode = new List<Movie>();
        IManagerAPI managerAPI = new ManagerAPI();

        Console.Write("\ntitle: ");
        string searchTitle = Console.ReadLine();
        title += searchTitle;
        if (string.IsNullOrEmpty(searchTitle))
            MainMenu();

        string newUrl = url + title + pageStr + $"{index}" + myKey;
        string contentString = managerAPI.GetContentString(newUrl);

        var option = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
        var search = JsonSerializer.Deserialize<Search>(contentString, option);

        if (bool.Parse(search.Response) is false)
        {
            Console.Clear();
            Console.WriteLine($"Response: {search.Response} , Error: {search.Error}");
            SortedToType();
        }

        var moviesList = search.Movies;

        for (int i = 0; i < moviesList.Count; i++)
        {
            if (moviesList[i].Type is "movie")
                moviesSort.Add(moviesList[i]);

            else if (moviesList[i].Type is "series")
                series.Add(moviesList[i]);

            else if (moviesList[i].Type is "episode")
                episode.Add(moviesList[i]);
        }

        Console.WriteLine("\n1.Movie");
        Console.WriteLine("2.Series");
        Console.WriteLine("3.Episode");
        Console.WriteLine("0.Orqaga");
        
        System.Console.Write("-->  ");

        int change = 0;

        try
        {
            change = Convert.ToInt32(Console.ReadLine());
        } catch (FormatException exception)
        {
            Console.Clear();
            Console.WriteLine(exception.Message);
            SortedToType();
        }

        switch (change)
        {
            case 1:
                {
                    MoviesSort(moviesSort);
                }
                break;
            case 2:
                {
                    Series(series);
                }
                break;
            case 3:
                {
                    Episode(episode);
                }
                break;
            case 0:
                {
                    MainMenu();
                }
                break;
            default:
                MainMenu();
                break;
        }
    }
    static void MoviesSort(List<Movie> moviesSort)
    {
        if (moviesSort.Count == 0)
        {
            System.Console.WriteLine("Movies toifasida topilmadi! ");
            SortedToType();
        }
        for (int i = 0; i < moviesSort.Count; )
        {
            Console.WriteLine(" == Search result == \n");
            System.Console.Write("Title: " + moviesSort[i].Title);
            System.Console.Write("Type: " + moviesSort[i].Type);
            System.Console.WriteLine();
            System.Console.WriteLine($"{i + 1} / {moviesSort.Count}");

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow && i < moviesSort.Count - 1)
                i++;
            else if (change == ConsoleKey.LeftArrow && i > 0)
                i--;
            else if (change == ConsoleKey.Backspace)
                SortedToType();

            Console.Clear();
        }
    }
    static void Series(List<Movie> series)
    {
        if (series.Count == 0)
        {
            System.Console.WriteLine("Series toifasida topilmadi! ");
            SortedToType();
        }
        for (int i = 0; i < series.Count; )
        {
            Console.WriteLine(" == Search result == \n");
            System.Console.Write("Title: " + series[i].Title);
            System.Console.Write("Type: " + series[i].Type);
            System.Console.WriteLine();
            System.Console.WriteLine($"{i + 1} / {series.Count}");

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow && i < series.Count - 1)
                i++;
            else if (change == ConsoleKey.LeftArrow && i > 0)
                i--;
            else if (change == ConsoleKey.Backspace)
                SortedToType();

            Console.Clear();
        }
    }
    static void Episode(List<Movie> episode)
    {
        if (episode.Count == 0)
        {
            System.Console.WriteLine("Episode toifasida topilmadi! ");
            SortedToType();
        }
        for (int i = 0; i < episode.Count; )
        {
            Console.WriteLine(" == Search result == \n");
            System.Console.Write("Title: " + episode[i].Title);
            System.Console.Write("Type: " + episode[i].Type);
            System.Console.WriteLine();
            System.Console.WriteLine($"{i + 1} / {episode.Count}");

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow && i < episode.Count - 1)
                i++;
            else if (change == ConsoleKey.LeftArrow && i > 0)
                i--;
            else if (change == ConsoleKey.Backspace)
                SortedToType();

            Console.Clear();
        }
    }
}