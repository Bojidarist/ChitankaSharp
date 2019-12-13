using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class ChitankaAPITextResult
    {
        [JsonProperty("query")]
        public CQuery Query { get; set; }

        [JsonProperty("texts")]
        public CText[] Texts { get; set; }

        [JsonProperty("found")]
        public bool Found { get; set; }
    }
}
