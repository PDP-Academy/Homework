namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s=Console.ReadLine();
            int i=int.Parse(Console.ReadLine());
            string url = $"https://omdbapi.com/?s={s}&page={i}&apikey=d8c25eb8";

           
            HttpClient client = new HttpClient();

            var response = client.GetAsync(url).Result;
            var json=response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(json);

        }
        static void Menu()
        {
            Console.WriteLine("Type buyich saralash");
            Console.WriteLine("Title buyic");
        }

        

    }
}