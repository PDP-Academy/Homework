
using System.Text.Json;
using System.Text.Json.Serialization;

namespace News
{
    public class Root
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("totalResults")]
        public int TotalResults { get; set; }

        [JsonPropertyName("articles")]
        public List<Article> Articles { get; set; }
    }
}
