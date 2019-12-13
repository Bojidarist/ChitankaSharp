using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CCountry
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nrOfAuthors")]
        public int NumberOfAuthors { get; set; }

        [JsonProperty("nrOfTranslators")]
        public int NumberOfTranslators { get; set; }
    }
}
