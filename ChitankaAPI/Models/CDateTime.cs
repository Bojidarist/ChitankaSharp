using Newtonsoft.Json;
using System;

namespace ChitankaAPI
{
    public class CDateTime
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("timezone_type")]
        public int? TimeZoneType { get; set; }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }
    }
}
