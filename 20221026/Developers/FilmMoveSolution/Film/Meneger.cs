using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
class Meneger
{
    public string keyUrl = "9ff58ab5";
    public string url = $"http://www.omdbapi.com/?i=tt3896198&apikey=";
    private List<Unknown> Search(string str)
    {
        if(str != "" && str != null)
        str = "?" + str.Substring(1);
        string URl = url + keyUrl + str;
        HttpClient client = new HttpClient();
        var temp = client.GetAsync(URl).Result;
        var temp2 = temp.Content.ReadAsStringAsync().Result;
        return JsonSerializer.Deserialize<List<Unknown>>(temp2);
    }
    public (List<Unknown>,List<Unknown>,List<Unknown>) SortedToList(List<Unknown>instance)
    {
        (List<Unknown>,List<Unknown>,List<Unknown>) sortedList = new (new List<Unknown>(),new List<Unknown>(),new List<Unknown>());
        for(int i=0;i<instance.Count;i++)
        {
            System.Console.WriteLine();
        }
        return sortedList;
    }
}


