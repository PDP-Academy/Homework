using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
class Meneger
{
    public string keyUrl = "9ff58ab5";
    public string url = $"http://www.omdbapi.com/?apikey=";
    public Result Search(string str)
    {
        string URl = url + keyUrl + str;
        HttpClient client = new HttpClient();
        var temp = client.GetAsync(URl).Result;
        var temp2 = temp.Content.ReadAsStringAsync().Result;
        return JsonSerializer.Deserialize<Result>(temp2);
    }
}