using System.Text.Json.Serialization;

namespace LeaderConsole
{
    internal class Search
    {
       [JsonPropertyName("Search")]
        public List<Movie> Movies { get; set; }
        public string TotalResults { get; set; }
        public string Response { get; set; }
    
    }
}
