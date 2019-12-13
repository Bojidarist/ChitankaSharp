using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CText
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("lang")]
        public CLanguage Language { get; set; }

        [JsonProperty("transYear")]
        public string TranslationYear { get; set; }

        [JsonProperty("transYear2")]
        public string TranslationYear2 { get; set; }

        [JsonProperty("origTitle")]
        public string OriginalTitle { get; set; }

        [JsonProperty("origSubtitle")]
        public string OriginalSubtitle { get; set; }

        [JsonProperty("origLang")]
        public CLanguage OriginalLanguage { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("year2")]
        public int? Year2 { get; set; }

        [JsonProperty("origLicense")]
        public CLicense OriginalLicense { get; set; }

        [JsonProperty("transLicense")]
        public CLicense TranslationLicense { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("series")]
        public CTextSeries Series { get; set; }

        [JsonProperty("sernr")]
        public int? SeriesNumber { get; set; }

        [JsonProperty("headlevel")]
        public int? HeadLevel { get; set; }

        [JsonProperty("createdAt")]
        public CDateTime CreatedAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("commentCount")]
        public int? CommentCount { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("votes")]
        public int? Votes { get; set; }

        [JsonProperty("hasAnno")]
        public bool HasAnnotation { get; set; }

        [JsonProperty("isCompilation")]
        public bool IsCompilation { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("article")]
        public string Article { get; set; }

        [JsonProperty("formats")]
        public string[] Formats { get; set; }

        [JsonProperty("removedNotice")]
        public string RemovedNotice { get; set; }

        [JsonProperty("authors")]
        public CPerson[] Authors { get; set; }

        [JsonProperty("translators")]
        public CPerson[] Translators { get; set; }
    }
}
