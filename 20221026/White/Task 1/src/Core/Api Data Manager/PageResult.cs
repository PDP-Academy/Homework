using System.Text.Json.Serialization;
namespace White.Core
{
    internal class PageResult : IPageResult
    {
        public string TotalResults { get ; set ; }
        public string Response { get ; set ; }
        [JsonPropertyName("Search")]
        public List<Movie> Results { get ; set ; }
    }
}
