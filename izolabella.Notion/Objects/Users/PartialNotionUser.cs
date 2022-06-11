using izolabella.Notion.Objects.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.Notion.Objects.Users
{
    public class PartialNotionUser : NotionObject
    {
        [JsonConstructor]
        public PartialNotionUser(string Id, NotionObjectType ObjectType, UserType Type) : base(Id, ObjectType)
        {
            this.Type = Type;
        }

        [JsonProperty("type")]
        public UserType Type { get; }
    }
}
