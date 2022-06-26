namespace izolabella.Notion.Objects.Util
{
    internal class Urls
    {
        internal static Uri BaseUrl => new("https://api.notion.com/v1/");

        internal static Uri GetDatabaseUrl(string DatabaseId)
        {
            return new Uri(Urls.BaseUrl, $"databases/{DatabaseId}");
        }
        internal static Uri GetQueryDatabaseUrl(string DatabaseId)
        {
            return new Uri(Urls.BaseUrl, $"databases/{DatabaseId}/query");
        }
    }
}
