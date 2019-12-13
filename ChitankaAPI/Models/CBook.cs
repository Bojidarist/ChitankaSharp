using Newtonsoft.Json;

namespace ChitankaAPI
{
    public class CBook
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("bibliomanId")]
        public int? BibliomanId { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("titleAuthor")]
        public string TitleAuthor { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("titleExtra")]
        public string TitleExtra { get; set; }

        [JsonProperty("origTitle")]
        public string OriginalTitle { get; set; }

        [JsonProperty("lang")]
        public CLanguage Language { get; set; }

        [JsonProperty("origLang")]
        public CLanguage OriginalLanguage { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }

        [JsonProperty("transYear")]
        public int? TranslationYear { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sequence")]
        public CSequence Sequence { get; set; }

        [JsonProperty("sequenceNr")]
        public int? SequenceNumber { get; set; }

        [JsonProperty("category")]
        public CCategory Category { get; set; }

        [JsonProperty("hasAnnotation")]
        public bool? HasAnnotation { get; set; }

        [JsonProperty("hasCover")]
        public bool? HasCover { get; set; }

        [JsonProperty("cover")]
        public string Cover { get; set; }

        [JsonProperty("formats")]
        public string[] Formats { get; set; }

        [JsonProperty("removedNotice")]
        public string RemovedNotice { get; set; }

        [JsonProperty("authors")]
        public CPerson[] Authors { get; set; }

        [JsonProperty("translators")]
        public CPerson[] Translators { get; set; }

        [JsonProperty("annotation")]
        public string Annotation { get; set; }
    }
}
