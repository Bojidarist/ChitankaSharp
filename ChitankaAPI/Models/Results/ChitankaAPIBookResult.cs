using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class ChitankaAPIBookResult
    {
        [JsonProperty("query")]
        public CQuery Query { get; set; }

        [JsonProperty("books")]
        public CBook[] Books { get; set; }

        [JsonProperty("found")]
        public bool Found { get; set; }
    }
}
