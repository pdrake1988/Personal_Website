using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Personal_Website.Models.Movie_Project
{
    public class Root : MovieResults
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("results")]
        public List<MovieResults> Results { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }
}