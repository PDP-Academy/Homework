
using System.Text.Json.Serialization;

namespace Green;
internal class Search
{
    [JsonPropertyName("Search")]
    public List<Movie> Movies { get; set; }
    public string TotalResults { get; set; }
    public string Response { get; set; }
    public string Error { get; set; }
}