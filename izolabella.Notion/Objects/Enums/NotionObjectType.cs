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
