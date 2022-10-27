using System;
using System.IO;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace task3;

class Program
{
    static void Main(string[] args)
    {
        string path = new Uri(new Uri(System.AppDomain.CurrentDomain.BaseDirectory), "data.txt").AbsolutePath;
        string name = "test";
        string api = "https://api.nationalize.io?";
        Console.WriteLine(path);

        HttpClient client = new HttpClient();
        var response = client.GetAsync(api + name).Result;
        string content = response.Content.ReadAsStringAsync().Result;


    }
}