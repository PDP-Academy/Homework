
using System.Text.Json;

namespace Task1;

internal class ManagerAPI : IManagerAPI
{
    public string GetApiKey => throw new NotImplementedException();

    public string GetContentString(string url)
    {
        HttpClient client = new HttpClient();

        client.BaseAddress = new Uri(url);

        var response = client.GetAsync(url).Result;
        var contentString = response.Content.ReadAsStringAsync().Result;

       return contentString;
    }
}
