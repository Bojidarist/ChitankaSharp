using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CSearchResult
    {
        [JsonProperty("nbResults")]
        public int NumberOfResults { get; set; }

        [JsonProperty("persons")]
        public CPerson[] Persons { get; set; }

        [JsonProperty("texts")]
        public CText[] Texts { get; set; }

        [JsonProperty("books")]
        public CBook[] Books { get; set; }

        [JsonProperty("series")]
        public CSeries[] Series { get; set; }

        [JsonProperty("sequences")]
        public CSequence[] Sequences { get; set; }

        [JsonProperty("labels")]
        public CLabel[] Labels { get; set; }

        [JsonProperty("categories")]
        public CCategory[] Categories { get; set; }
    }
}
