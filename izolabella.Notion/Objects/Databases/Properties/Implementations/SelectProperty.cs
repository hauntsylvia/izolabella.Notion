using izolabella.Notion.Objects.Databases.Properties.Bases;
using izolabella.Notion.Objects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
