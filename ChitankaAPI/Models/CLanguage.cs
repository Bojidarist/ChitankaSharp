using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CLanguage
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
