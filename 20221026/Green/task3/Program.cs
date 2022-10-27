using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace task3;

class Program
{
    static string api = "https://api.nationalize.io?name=";
    static void Main(string[] args)
    {
        var nationalityOfNames = new List<Country>();
        var names = GetNames();

        for (int i = 0; i < names.Count; i++)
        {
            nationalityOfNames.Add(PredictNationalityOfName(names[i]));

            var country = nationalityOfNames[i];
            Console.WriteLine($"Country Id: {country.Country_id}");
            Console.WriteLine($"Probability: {country.Probability}");
        }
       

    }

    static Country PredictNationalityOfName(string name)
    {
        HttpClient client = new HttpClient();
        var response = client.GetAsync(api + name).Result;
        string content = response.Content.ReadAsStringAsync().Result;

        var option = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        var dataFromApi = JsonSerializer.Deserialize<DataFromAPI>(content, option);
        var countries = dataFromApi.Country;

        return countries[0];
    }

    static List<string> GetNames()
    {
        var namesList = new List<string>();
        string path = new Uri(new Uri(System.AppDomain.CurrentDomain.BaseDirectory), "../../../names.txt").AbsolutePath;
        Console.WriteLine(path);
        using (StreamReader streamReader = new StreamReader(path))
        {
            while (!streamReader.EndOfStream)
            {
                namesList.Add(streamReader.ReadLine());
            }
        }

        return namesList;
    }
}