using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CPerson
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("origName")]
        public string OriginalName { get; set; }

        [JsonProperty("realName")]
        public string RealName { get; set; }

        [JsonProperty("origRealName")]
        public string OriginalRealName { get; set; }

        [JsonProperty("isAuthor")]
        public bool? IsAuthor { get; set; }

        [JsonProperty("isTranslator")]
        public bool? IsTranslator { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public CCountry Country { get; set; }
    }
}
