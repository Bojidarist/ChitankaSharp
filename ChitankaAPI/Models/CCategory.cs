using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CCategory
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("nrOfBooks")]
        public int? NumberOfBooks { get; set; }
    }
}
