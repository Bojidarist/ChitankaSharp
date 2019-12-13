using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CTextSeries
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("origName")]
        public string OriginalName { get; set; }

        [JsonProperty("authors")]
        public CPerson Authors { get; set; }
    }
}
