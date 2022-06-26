using izolabella.Notion.Objects.Enums;

namespace izolabella.Notion.Objects.NotionBases
{
    public class NotionObject
    {
        public NotionObject(string Id, NotionObjectType ObjectType)
        {
            this.Id = Id;
            this.ObjectType = ObjectType;
        }

        /// <summary>
        /// The unique identifier this instance represents.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; }

        /// <summary>
        /// The type of object this instance represents.
        /// </summary>
        [JsonProperty("object")]
        public NotionObjectType ObjectType { get; }

        /// <summary>
        /// The client this instance was made with.
        /// </summary>
        internal NotionClient MadeWith { get; set; }
    }
}
