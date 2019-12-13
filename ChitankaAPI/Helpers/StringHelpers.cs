using System.Net;

namespace ChitankaAPI.Helpers
{
    public static class StringHelpers
    {
        public static string DownloadStringFromURL(this string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }
    }
}
