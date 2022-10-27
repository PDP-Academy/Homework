using Movies;
using System.Text.Json;

namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Film nomi: ");
                string nameFilm = Console.ReadLine();
                Type();
                int nameTypePosition = int.Parse(Console.ReadLine());
                string nameType;
                if (nameTypePosition == 1)
                    nameType = "movie";
                else if (nameTypePosition == 2)
                    nameType = "series";
                else
                    nameType = "episode";


                string url = $"https://omdbapi.com/?s={nameFilm}&type={nameType}&page=1&apikey=d8c25eb8";
                Search search = GetSearchByUrl(url);
                int count = int.Parse(search.TotalResults) / 10;
                int pasition = 1;
                if (count == 0)
                {
                    Console.WriteLine("munday film topilmadi!!!\nQaytadan urinib korish uchun istalgan keyni bosing:");
                    var key = Console.ReadKey(false).Key;
                    Console.Clear();
                }
                    while (pasition <= count)
                {
                    url = $"https://omdbapi.com/?s={nameFilm}&type={nameType}&page={pasition}&apikey=d8c25eb8";
                    search = GetSearchByUrl(url);
                    foreach (var item in search.Movie)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();
                    Console.WriteLine("=============================");

                    if (pasition != 1)
                        Console.Write("<-" + (pasition - 1)+"    ");
                    if (pasition != count)
                        Console.Write("     "+(pasition + 1) + "->");
                    var strelka = Console.ReadKey(false).Key;
                    Console.Clear();
                    switch (strelka)
                    {
                        case ConsoleKey.RightArrow:

                            if (pasition != count)
                                pasition++;


                            break;
                        case ConsoleKey.LeftArrow:
                            if (pasition != 1)
                                pasition--;

                            break;
                        case ConsoleKey.UpArrow:
                            pasition = count + 1;
                            break;

                    }

                }
            }
        }


        private static Search GetSearchByUrl(string url)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var search = JsonSerializer.Deserialize<Search>(json, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });

            return search;
        }

        static void Type()
        {
            Console.WriteLine("1.movie \n2.series \n3.episode");
            Console.Write("Tanlab yozing: ");

        }
    }
}