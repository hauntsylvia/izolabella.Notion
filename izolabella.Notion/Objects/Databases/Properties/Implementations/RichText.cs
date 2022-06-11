using izolabella.Notion.Objects.Databases.Properties.Bases;
using izolabella.Notion.Objects.Enums;
using izolabella.Notion.Objects.Util.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.Notion.Objects.Databases.Properties.Implementations
{
    public class RichText : DatabaseObjectProperty
    {
        [JsonConstructor]
        public RichText(string Id, TextProperty[] RichTextContent, string Name,PropertyType PT) : base(Id, PT, Name)
        {
            this.RichTextContent = RichTextContent;
        }

        [JsonProperty("rich_text")]
        [JsonConverter(typeof(SingleOrArrayConverter<TextProperty>))]
        public TextProperty[] RichTextContent { get; }
    }
}
