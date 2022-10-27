using System.Text.Json;
using System.Text.Json.Serialization;

namespace White.Core;

internal class ApiDataManager : IApiDataManager
{

    // /<Summary>O'zida API uchun key saqlaydi</Summary>
    private string ApiKey { get => "9e6adc8a"; }

    ///<Summary>API URL base</Summary>
    private string ApiUrl { get => "http://omdbapi.com/"; }

    public List<IMovie> SearchDataByTitle(string title, int page)
    {
        HttpClient client = new HttpClient();
        string url = ApiUrl + "?s=" + title + "&page=" + page.ToString() + "&apikey=" + this.ApiKey;
        var response = client.GetAsync(url).Result;
        var data = response.Content.ReadAsStringAsync().Result;
        var allMovies = JsonSerializer.Deserialize<ApiResponse>(data);
        return allMovies.Movies.ToList<IMovie>();
    }
}


internal class ApiResponse
{
    [JsonPropertyName("Search")]
    public List<Movie> Movies { get; set; }
    public string Response { get; set; }
    public string TotalResults { get; set; }
    
}