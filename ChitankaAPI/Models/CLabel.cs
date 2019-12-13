using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CLabel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("nrOfTexts")]
        public int NumberOfTexts { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }
}
