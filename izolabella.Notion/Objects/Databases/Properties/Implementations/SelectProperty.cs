using izolabella.Notion.Objects.Databases.Properties.Bases;
using izolabella.Notion.Objects.Enums;

namespace izolabella.Notion.Objects.Databases.Properties.Implementations
{
    public class SelectProperty : DatabaseObjectProperty
    {
        public SelectProperty(string Id, string Name, SelectContent Selected) : base(Id, PropertyType.Select, Name)
        {
            this.Selected = Selected;
        }

        [JsonProperty("select")]
        public SelectContent Selected { get; }
    }
}
