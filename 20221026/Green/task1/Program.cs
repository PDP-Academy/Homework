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
        System.Console.WriteLine();
        System.Console.Write("-->  ");

        int change = Convert.ToInt32(Console.ReadLine());

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

        Console.Write("title: ");
        title += Console.ReadLine();
        int pages = 10;

        while (index <= pages / 10 && index > 0)
        {
            string newUrl = url + title + pageStr + $"{index}" + myKey;
            string contentString = managerAPI.GetContentString(newUrl);

            var option = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            var search = JsonSerializer.Deserialize<Search>(contentString, option);

            var moviesList = search.Movies;
            pages = int.Parse(search.TotalResults);

            foreach (var item in moviesList)
            {
                Console.WriteLine("  Title: " + item.Title);
            }
            Console.Write($"\t{index}/{pages / 10}");

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow)
                index++;
            else if (change == ConsoleKey.LeftArrow)
                index--;
            else if (change == ConsoleKey.Backspace)
                MainMenu();

            Console.Clear();
        }
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

        Console.Write("title: ");
        title += Console.ReadLine();

        string newUrl = url + title + pageStr + $"{index}" + myKey;
        string contentString = managerAPI.GetContentString(newUrl);

        var option = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
        var search = JsonSerializer.Deserialize<Search>(contentString, option);

        var moviesList = search.Movies;

        for (int i = 0; i < moviesList.Count; i++)
        {
            if (moviesList[i].Type == "movie")
                moviesSort.Add(moviesList[i]);

            else if (moviesList[i].Type == "series")
                series.Add(moviesList[i]);

            else if (moviesList[i].Type == "episode")
                episode.Add(moviesList[i]);
        }

        Console.WriteLine("1.Movie");
        Console.WriteLine("2.Series");
        Console.WriteLine("3.Episode");
        Console.WriteLine("0.Orqaga");
        System.Console.WriteLine();
        System.Console.WriteLine("-->  ");
        int change = Convert.ToInt32(Console.ReadLine());

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
        for (int i = 0; i < moviesSort.Count;)
        {
            System.Console.WriteLine("Title: " + moviesSort[i].Title);
            System.Console.WriteLine("Type: " + moviesSort[i].Type);
            System.Console.WriteLine();
            System.Console.WriteLine($"{i + 1} / {moviesSort.Count}");

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow)
                i++;
            else if (change == ConsoleKey.LeftArrow && i != 0)
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
        for (int i = 0; i < series.Count; i++)
        {
            System.Console.WriteLine("Title: " + series[i].Title);
            System.Console.WriteLine("Type: " + series[i].Type);
            System.Console.WriteLine();
            System.Console.WriteLine($"{i + 1} / {series.Count}");

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow)
                i++;
            else if (change == ConsoleKey.LeftArrow)
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
        for (int i = 0; i < episode.Count; i++)
        {
            System.Console.WriteLine("Title: " + episode[i].Title);
            System.Console.WriteLine("Type: " + episode[i].Type);
            System.Console.WriteLine();
            System.Console.WriteLine($"{i + 1} / {episode.Count}");

            var change = Console.ReadKey().Key;

            if (change == ConsoleKey.RightArrow)
                i++;
            else if (change == ConsoleKey.LeftArrow)
                i--;
            else if (change == ConsoleKey.Backspace)
                SortedToType();

            Console.Clear();
        }
    }
}