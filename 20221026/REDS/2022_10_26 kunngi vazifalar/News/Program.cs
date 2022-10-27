using System.Text.Json;

namespace News
{
    public class Program
    {
        static string urlEverything = @"https://newsapi.org/v2/everything?q=bitcoin&apiKey=877ae87ec3514cfdba8409fdd0f5a6ed";
        static string urlTopHeadlines = @"https://newsapi.org/v2/top-headlines?country=us&apiKey=877ae87ec3514cfdba8409fdd0f5a6ed";
        static string urlSourseBBC = @"https://newsapi.org/v2/top-headlines?sources=bbc-news&apiKey=877ae87ec3514cfdba8409fdd0f5a6ed";
        static Root root;
        static void Main(string[] args)
        {
            string[] urls = { urlEverything, urlTopHeadlines, urlSourseBBC };
            int url = 1;
            root = GetNewsRoot(urls[url]);
            //Console.WriteLine(root.Articles.Count);
            ConsoleKey key = ConsoleKey.P;
            int index = 0;
            while (true)
            {
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (index > 0) index--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (index < root.Articles.Count - 1) index++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (url > 0) url--;
                        else url = 2;
                        root = GetNewsRoot(urls[url]);
                        break;
                    case ConsoleKey.RightArrow:
                        if (url < 2) url++;
                        else url = 0;
                        root = GetNewsRoot(urls[url]);
                        break;
                        default: break;
                }
                show(index);
                string[] type = { "Everything", "TopHeadlines", "SourseBBC" };
                for (int i = 0; i < urls.Length; i++)
                {
                    Console.BackgroundColor= ConsoleColor.Black;
                    if(i==url)
                    Console.BackgroundColor= ConsoleColor.Red;
                    Console.Write("      " + type[i]);
                }
                key = Console.ReadKey(false).Key;
            }
        }

        private static void show(int index)
        {
            Article article = root.Articles[index];
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            article.Title= Formatter(article.Title,45);
            Console.WriteLine(article.Title + $"                 {index}/{root.TotalResults} ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(article.Source.Name + ":    ->   " + article.Author);
            article.Description = Formatter(article.Description, 55);
            Console.WriteLine("\n" + article.Description);
            article.Description = Formatter(article.Content, 60);
            Console.WriteLine("\n" + article.Content);
            DateTime t = article.PublishedAt;
            Console.WriteLine("                            " + t.Day + "/" + t.Month + "/" + t.Year + "--" + t.Hour + ":" + t.Minute);
            Console.WriteLine("more: "+article.Url);
            
           
        }
        private static string Formatter(string str,int length)
        {
            for (int i = 0; i < str.Length; i+= length)
            {
                str.Insert(i, "-\n");
            }
            return str;
        }
        private static Root GetNewsRoot(string url)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            var json = response.Content.ReadAsStringAsync().Result;
          //  Console.WriteLine(json);
            return JsonSerializer.Deserialize<Root>(json);
        }
    }
}