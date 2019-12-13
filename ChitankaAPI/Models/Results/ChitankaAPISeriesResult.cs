using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class ChitankaAPISeriesResult
    {
        [JsonProperty("query")]
        public CQuery Query { get; set; }

        [JsonProperty("series")]
        public CSeries[] Series { get; set; }

        [JsonProperty("found")]
        public bool Found { get; set; }
    }
}
