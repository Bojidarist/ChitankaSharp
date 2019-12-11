using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CQuery
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("by")]
        public string By { get; set; }

        [JsonProperty("match")]
        public string Match { get; set; }
    }
}
