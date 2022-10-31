using System.Text.Json.Serialization;

namespace Movies
{

    public class Search
    {
        [JsonPropertyName("Search")]
        public List<Movie> Movie { get; set; }
        [JsonPropertyName("totalResults")]
        public string TotalResults { get; set; }
        public string Response { get; set; }  
        public override string ToString()
        {
            return $"InfoOfMovie:,Total results:{TotalResults},Response:{Response}"; 
        }

    }
}
