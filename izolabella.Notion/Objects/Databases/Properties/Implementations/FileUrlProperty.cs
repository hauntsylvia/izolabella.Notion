namespace izolabella.Notion.Objects.Databases.Properties.Implementations
{
    public class FileUrlProperty
    {
        [JsonConstructor]
        public FileUrlProperty(FileContent Content)
        {
            this.Content = Content;
        }

        [JsonProperty("file")]
        public FileContent Content { get; }
    }
}
