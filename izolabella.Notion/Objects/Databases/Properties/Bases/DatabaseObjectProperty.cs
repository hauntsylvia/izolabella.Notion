using izolabella.Notion.Objects.Enums;

namespace izolabella.Notion.Objects.Databases.Properties.Bases
{
    public class DatabaseObjectProperty : NotionObject
    {
        public DatabaseObjectProperty(string Id, PropertyType PropertyType, string Name, Uri? HRef = null) : base(Id, NotionObjectType.Property)
        {
            this.PropertyType = PropertyType;
            this.Name = Name;
            this.HRef = HRef;
        }

        [JsonProperty("type")]
        public PropertyType PropertyType { get; }

        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("href")]
        public Uri? HRef { get; }
    }
}
