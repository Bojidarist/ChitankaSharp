using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class ChitankaAPISequencesResult
    {
        [JsonProperty("query")]
        public CQuery Query { get; set; }

        [JsonProperty("sequences")]
        public CSequence[] Sequences { get; set; }

        [JsonProperty("found")]
        public bool Found { get; set; }
    }
}
