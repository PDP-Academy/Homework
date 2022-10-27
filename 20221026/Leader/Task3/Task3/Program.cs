using System.Text.Json.Serialization;
using System.Net.Http;
using System.Text.Json;
using Task3;
using System.Diagnostics;

class Progaram
{
    static void Main(string[] args)
    {
        Stopwatch watch = new Stopwatch();
        watch.Start();
        string path = "C:\\Users\\ravsh\\Desktop\\Homework\\20221026\\Leader\\Task3\\Task3\\names.txt";
        double persent = 1;
        List<string> list = File.ReadAllLines(path).ToList();
        List<string> names = new List<string>();

        for (int i =0; i<8; i++) 
        {
            if (ValidName(list[i],persent) is not null)
                names.Add(list[i]);
        }
        Console.WriteLine(names.Count);
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
        watch.Stop();
        Console.WriteLine(watch.ElapsedMilliseconds);
    }

    static string ValidName(string name, double percent)
    {
        Stopwatch watch = new Stopwatch();
        watch.Start();
        string url = "https://api.nationalize.io?name=";
        url += name;

        HttpClient client = new HttpClient();
        var response = client.GetAsync(url).Result;
        var jsondata = response.Content.ReadAsStringAsync().Result;

        var data = JsonSerializer.Deserialize<Root>(jsondata);

        watch.Stop();
        Console.WriteLine(watch.ElapsedMilliseconds);
        if (data.country[0].probability * 100 > percent)
            return data.name;

        return null;

    }

}