using System.Text.Json;

namespace ConsoleApp1
{
    public class Program
    {
        static string myKey = "apiKey=783ccc206b8247c1a1f328e8bf555a39";
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("1.So‘nggi 4 yil ichida 80 000 dan ortiq turli xil katta" +
                " va kichik manbalar tomonidan chop etilgan har bir maqolani qidirish.\n" +
                "2.Mamlakatlar, toifalar va alohida nashriyotlar uchun so‘nggi yangiliklar" +
                " maqolalarini qidirish.\n" +
                "3.Eng muhim sarlavhalarni olish uchun mavjud bo'lgan eng mashhur manbalar " +
                "haqidagi ma'lumotlarni (jumladan, nomi, tavsifi va toifasi) qidirish\n" +
                "Any number except above.Exit");

            int key = int.Parse(Console.ReadLine());

            switch(key)
            {
                case 1:
                    SearchArticleInLastFourYear();
                    break;
                case 2:
                    SearchLastNewsOfCountry();
                    break;
                case 3:
                    WiewTheMostPopularSources();
                    break;

            }
        }

        static void WiewTheMostPopularSources()
        {
            string url = "https://newsapi.org/v2/top-headlines/sources?";

        }

        static void SearchLastNewsOfCountry()
        {
            string url = "https://newsapi.org/v2/top-headlines?";

            string order = String.Empty;
            while (true)
            {
                Console.WriteLine("1.Country.\n" +
                    "2.Category\n" +
                    "3.Sources\n" +
                    "Enter.Search\n" +
                    "Backspace.Exit");

                var key = Console.ReadKey().Key;
                string enterString = "";
                if (key != ConsoleKey.Enter && key != ConsoleKey.Backspace)
                {
                    if (order != String.Empty)
                        order += "&";
                    Console.Write("\nEnter information : ");
                    enterString = Console.ReadLine();
                }
                switch (key)
                {
                    case ConsoleKey.D1:
                        order += $"country={enterString}";
                        break;
                    case ConsoleKey.D2:
                        order += $"category={enterString}";
                        break;
                    case ConsoleKey.D3:
                        order += $"sources={enterString}";
                        break;
                    case ConsoleKey.Backspace:
                        Menu();
                        break;
                    case ConsoleKey.Enter:
                        SearchArticleByGivenDate(url + order);
                        break;
                }
            }
        }
        static void SearchArticleInLastFourYear()
        {
            string url = "https://newsapi.org/v2/everything?";

            string order = String.Empty;
            while (true)
            {
                Console.WriteLine("1.Title, description or content.\n" +
                    "2.Domain\n" +
                    "3.Source\n" +
                    "4.Date time from (2022-10-28 or 2022-10-28T06:29:02)\n" +
                    "5.Date time to (2022-10-28 or 2022-10-28T06:29:02)\n" +
                    "6.Language\n" +
                    "7.Sort by ( relevancy, popularity, publishedAt)\n" +
                    "Enter.Search\n" +
                    "Backspace.Exit");

                var key = Console.ReadKey().Key;
                string enterString = "";
                if (key != ConsoleKey.Enter && key != ConsoleKey.Backspace)
                {
                    if (order != String.Empty)
                        order += "&";
                    Console.Write("\nEnter information : ");
                    enterString = Console.ReadLine();
                }
                switch (key)
                {
                    case ConsoleKey.D1:
                        order += $"q={enterString}";
                        break;
                    case ConsoleKey.D2:
                        order += $"domains={enterString}";
                        break;
                    case ConsoleKey.D3:
                        order += $"source={enterString}";
                        break;
                    case ConsoleKey.D4:
                        order += $"from={enterString}";
                        break;
                    case ConsoleKey.D5:
                        order += $"to={enterString}";
                        break;
                    case ConsoleKey.D6:
                        order += $"language={enterString}";
                        break;
                    case ConsoleKey.D7:
                        order += $"sortBy={enterString}";
                        break;
                    case ConsoleKey.Backspace:
                        Menu();
                        break;
                    case ConsoleKey.Enter:
                        SearchArticleByGivenDate(url + order);
                        break;
                }
            }
        }

        static void SearchArticleByGivenDate(string v)
        {
            v = v + "&" + myKey;
            Console.WriteLine(v);
            Root root = GetObjectByUrl(v);
            string? status = root.Status;
            int? totalResults = root.TotalResults;
            
            Console.WriteLine($"Status : {status}\n" +
                $"Total results : {totalResults}");
            if (root.Articles != null)
            {
                for (int i = 0; i < root.Articles.Count;i++)
                {
                    Console.WriteLine($"{i + 1} - article source name : {root.Articles[i].Source.Name}\n" +
                        $"{i + 1} - article source id : {root.Articles[i].Source.Id}\n" +
                        $"{i + 1} - article author : {root.Articles[i].Author}\n" +
                        $"{i + 1} - article title : {root.Articles[i].Title}\n" +
                        $"{i + 1} - article description : {root.Articles[i].Description}\n" +
                        $"{i + 1} - article url : {root.Articles[i].Url}\n" +
                        $"{i + 1} - article url to image : {root.Articles[i].UrlToImage}\n" +
                        $"{i + 1} - article Date time : {root.Articles[i].PublishedAt}\n" +
                        $"{i + 1} - article content : {root.Articles[i].Content}");
                }
                
                var key = Console.ReadKey().Key;   
                if (key == ConsoleKey.Backspace)
                    Menu();               
            }

        }
        static Root GetObjectByUrl(string url)
        {
            HttpClient client = new HttpClient();

            var response = client.GetAsync(url).Result;

            var contentString = response.Content.ReadAsStringAsync().Result;

            var serializationOption = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            Root root = JsonSerializer.Deserialize<Root>(contentString, serializationOption);

            return root;
        }
    }

    }
