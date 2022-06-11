using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.Notion.Objects.Enums
{
    public enum NotionObjectType
    {
        [JsonProperty("user")]
        User,

        [JsonProperty("database")]
        Database,

        Property,

        [JsonProperty("page")]
        Page,

        [JsonProperty("list")]
        List
    }
}
