namespace izolabella.Notion.Objects.Enums
{
    /// <summary>
    /// Enums for notion user types.
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// Indicates this user is a person.
        /// </summary>
        [JsonProperty("person")]
        Person,

        /// <summary>
        /// Indicates this user is a bot.
        /// </summary>
        [JsonProperty("bot")]
        Bot
    }
}
