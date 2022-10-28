using static LeaderConsole.Api;

namespace LeaderConsole;

internal class Api
{
    public string GetContentString(string url)
    {
        HttpClient client = new HttpClient();

        client.BaseAddress = new Uri(url);

        var response = client.GetAsync(url).Result;
        var contentString = response.Content.ReadAsStringAsync().Result;

        return contentString;
    }
}

