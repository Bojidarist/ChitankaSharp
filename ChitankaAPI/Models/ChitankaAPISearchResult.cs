using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class ChitankaAPISearchResult
    {
        [JsonProperty("query")]
        public CQuery Query { get; set; }

        [JsonProperty("result")]
        public CSearchResult Result { get; set; }
    }
}
