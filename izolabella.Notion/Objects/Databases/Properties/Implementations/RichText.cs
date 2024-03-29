﻿using izolabella.Notion.Objects.Databases.Properties.Bases;
using izolabella.Notion.Objects.Enums;
using izolabella.Notion.Objects.Util.Converters;

namespace izolabella.Notion.Objects.Databases.Properties.Implementations
{
    /// <summary>
    /// Rich text property.
    /// </summary>
    public class RichText : DatabaseObjectProperty
    {
        [JsonConstructor]
        internal RichText(string Id, TextProperty[] RichTextContent, string Name, PropertyType PT) : base(Id, PT, Name)
        {
            this.RichTextContent = RichTextContent;
        }

        /// <summary>
        /// Rich text property's content.
        /// </summary>
        [JsonProperty("rich_text")]
        [JsonConverter(typeof(SingleOrArrayConverter<TextProperty>))]
        public TextProperty[] RichTextContent { get; }
    }
}
