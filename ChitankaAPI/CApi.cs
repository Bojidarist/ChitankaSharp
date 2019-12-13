using ChitankaAPI.Helpers;
using Newtonsoft.Json;

namespace ChitankaAPI
{
    public static class CApi
    {
        #region Methods

        public static ChitankaAPISearchResult Search(string query, string by = "", string match = "")
        {
            string json = $"https://chitanka.info/search.json?q={ query }&by={ by }&match={ match }".DownloadStringFromURL();
            var result = JsonConvert.DeserializeObject<ChitankaAPISearchResult>(json);
            return result;
        }

        public static ChitankaAPIBookResult SearchBooks(string query, string by = "", string match = "")
        {
            string json = $"https://chitanka.info/books/search.json?q={ query }&by={ by }&match={ match }".DownloadStringFromURL();
            var result = JsonConvert.DeserializeObject<ChitankaAPIBookResult>(json);
            return result;
        }

        public static ChitankaAPITextResult SearchTexts(string query, string by = "", string match = "")
        {
            string json = $"https://chitanka.info/texts/search.json?q={ query }&by={ by }&match={ match }".DownloadStringFromURL();
            var result = JsonConvert.DeserializeObject<ChitankaAPITextResult>(json);
            return result;
        }

        public static ChitankaAPIPersonsResult SearchPersons(string query, string by = "", string match = "")
        {
            string json = $"https://chitanka.info/persons/search.json?q={ query }&by={ by }&match={ match }".DownloadStringFromURL();
            var result = JsonConvert.DeserializeObject<ChitankaAPIPersonsResult>(json);
            return result;
        }

        public static ChitankaAPISeriesResult SearchSeries(string query, string by = "", string match = "")
        {
            string json = $"https://chitanka.info/series/search.json?q={ query }&by={ by }&match={ match }".DownloadStringFromURL();
            var result = JsonConvert.DeserializeObject<ChitankaAPISeriesResult>(json);
            return result;
        }

        public static ChitankaAPISequencesResult SearchSequences(string query, string by = "", string match = "")
        {
            string json = $"https://chitanka.info/sequences/search.json?q={ query }&by={ by }&match={ match }".DownloadStringFromURL();
            var result = JsonConvert.DeserializeObject<ChitankaAPISequencesResult>(json);
            return result;
        }

        #endregion
    }
}
