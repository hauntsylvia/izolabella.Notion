using izolabella.Notion.Objects.Databases.Properties.Bases;
using izolabella.Notion.Objects.Enums;

namespace izolabella.Notion.Objects.Databases.Properties.Implementations
{
    public class TextProperty : DatabaseObjectProperty
    {
        public TextProperty(string Id, TextContent Text, string PlainText, string Name) : base(Id, PropertyType.Text, Name)
        {
            this.Text = Text;
            this.PlainText = PlainText;
        }

        [JsonProperty("text")]
        public TextContent Text { get; }

        [JsonProperty("plain_text")]
        public string PlainText { get; }
    }
}
