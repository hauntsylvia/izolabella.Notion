using izolabella.Notion.Objects.Databases.Properties.Bases;
using izolabella.Notion.Objects.Enums;

namespace izolabella.Notion.Objects.Databases.Properties.Implementations
{
    public class DateTimeProperty : DatabaseObjectProperty
    {
        public DateTimeProperty(string Id, string Name, DateContent DateComponent) : base(Id, PropertyType.Date, Name)
        {
            this.DateComponent = DateComponent;
        }

        [JsonProperty("date")]
        public DateContent DateComponent { get; }
    }
}
