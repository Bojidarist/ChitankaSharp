using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CSequence
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("anntation")]
        public string Annotation { get; set; }

        [JsonProperty("isSeqnrVisible")]
        public bool IsSequenceNumberVisible { get; set; }

        [JsonProperty("nrOfBooks")]
        public int? NumberOfBooks { get; set; }
    }
}
