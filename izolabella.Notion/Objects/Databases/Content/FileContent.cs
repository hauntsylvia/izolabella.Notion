namespace izolabella.Notion.Objects.Databases.Content
{
    public class FileContent
    {
        [JsonConstructor]
        public FileContent(string Url)
        {
            this.Url = Url;
        }

        [JsonProperty("url")]
        public string Url { get; }
    }
}
