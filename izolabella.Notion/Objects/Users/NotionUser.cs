namespace izolabella.Notion.Objects.Users
{
    public class NotionUser : NotionObject
    {
        [JsonConstructor]
        public NotionUser(string Id, string? Name, Uri? AvatarUrl) : base(Id, Enums.NotionObjectType.User)
        {
            this.Name = Name;
            this.AvatarUrl = AvatarUrl;
        }

        [JsonProperty("name")]
        public string? Name { get; }

        [JsonProperty("avatar_url")]
        public Uri? AvatarUrl { get; }
    }
}
