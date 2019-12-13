using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CLicense
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("isFree")]
        public bool IsFree { get; set; }

        [JsonProperty("isCopyright")]
        public bool IsCopyright { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }
    }
}
