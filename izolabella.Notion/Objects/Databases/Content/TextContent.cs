namespace izolabella.Notion.Objects.Databases.Content
{
    public class TextContent
    {
        public TextContent(string PlainText)
        {
            this.PlainText = PlainText;
        }

        [JsonProperty("plain_text")]
        public string PlainText { get; }
    }
}
