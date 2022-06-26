using izolabella.Notion.Objects.Databases.Properties.Bases;
using izolabella.Notion.Objects.Enums;

namespace izolabella.Notion.Objects.Databases.Properties.Implementations
{
    /// <summary>
    /// File property.
    /// </summary>
    public class FileProperty : DatabaseObjectProperty
    {
        [JsonConstructor]
        internal FileProperty(string Id, FileContent FileContent, string Name, PropertyType PT) : base(Id, PT, Name)
        {
            this.FileContent = FileContent;
        }

        /// <summary>
        /// File property's inner content.
        /// </summary>
        [JsonProperty("file")]
        public FileContent FileContent { get; }
    }
}
