using izolabella.Notion.Objects.Databases.Properties.Bases;
using izolabella.Notion.Objects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
