using System.Text.Json;

namespace White.Core;

internal class ApiDataManager : IApiDataManager
{

    // /<Summary>O'zida API uchun key saqlaydi</Summary>
    private string ApiKey { get => "9e6adc8a"; }

    ///<Summary>API URL base</Summary>
    private string ApiUrl { get => "http://omdbapi.com/"; }

       public List<Movie> SearchDataByTitle(string title, int page)
    {
        HttpClient client = new HttpClient();
        string url = this.ApiUrl + "?s=" + title + "&page=" + page.ToString() + "&apikey=" + this.ApiKey;
        var response = client.GetAsync(url).Result;
        var data = response.Content.ReadAsStringAsync().Result;
        var allMovies = JsonSerializer.Deserialize<PageResult>(data, new JsonSerializerOptions(JsonSerializerDefaults.General));
        Console.WriteLine(allMovies.Results.Count);
            return allMovies.Results;
    }
}