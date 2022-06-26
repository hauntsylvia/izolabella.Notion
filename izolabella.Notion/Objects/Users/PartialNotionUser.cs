using izolabella.Notion.Objects.Enums;

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
