using System.Text.Json;

namespace White.Core;

internal class ApiDataManager : IApiDataManager
{

    // /<Summary>O'zida API uchun key saqlaydi</Summary>
    private string ApiKey { get; }

    ///<Summary>API URL base</Summary>
    private string ApiUrl { get => "http://img.omdbapi.com/"; }

    public List<object> GetDataFromApi()
    {
        throw new NotImplementedException();
    }


    public List<IResult> SearchDataByTitle(string title, int page)
    {
        HttpClient client = new HttpClient();
        string url = ApiUrl + "?s" + title + "&page=" + page.ToString();
        var response = client.GetAsync(url).Result;
        var data = response.Content.ReadAsStringAsync().Result;
        var allMovies = JsonSerializer.Deserialize<IPageResult>(data);
            return allMovies.Results;
    }
}