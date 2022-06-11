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
    public class TitleProperty : DatabaseObjectProperty
    {
        public TitleProperty(string Id, PropertyType PropertyType, string Name, TextProperty[] TitleText, Uri? HRef = null) : base(Id, PropertyType, Name, HRef)
        {
            this.TitleText = TitleText;
        }

        [JsonProperty("title")]
        [JsonConverter(typeof(SingleOrArrayConverter<TextProperty>))]
        public TextProperty[] TitleText { get; }
    }
}
