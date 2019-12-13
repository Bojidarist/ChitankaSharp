using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class ChitankaAPIPersonsResult
    {
        [JsonProperty("query")]
        public CQuery Query { get; set; }

        [JsonProperty("persons")]
        public CPerson[] Persons { get; set; }

        [JsonProperty("found")]
        public bool Found { get; set; }
    }
}
