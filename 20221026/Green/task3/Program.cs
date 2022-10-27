using System;
using System.IO;
namespace task3;

class Program
{
    static void Main(string[] args)
    {
        
        string name = "test";
        string api = "https://api.nationalize.io?";

        HttpClient client = new HttpClient();
        var response = client.GetAsync(api + name).Result;
        string content = response.Content.ReadAsStringAsync().Result;


    }
}