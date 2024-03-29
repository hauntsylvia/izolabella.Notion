﻿using izolabella.Notion.Objects.Databases.Properties.Implementations;
using izolabella.Notion.Objects.Enums;
using izolabella.Notion.Objects.Users;

namespace izolabella.Notion.Objects.Databases
{
    public class PageObject<TProperties> : NotionObject
    {
        public PageObject(string Id,
                          NotionObjectType ObjectType,
                          DateTime CreatedAt,
                          DateTime LastEditedAt,
                          PartialNotionUser CreatedBy,
                          PartialNotionUser LastEditedBy,
                          TProperties Properties,
                          FileProperty? Cover) : base(Id, ObjectType)
        {
            this.CreatedAt = CreatedAt;
            this.LastEditedAt = LastEditedAt;
            this.CreatedBy = CreatedBy;
            this.LastEditedBy = LastEditedBy;
            this.Properties = Properties;
            this.Cover = Cover;
        }

        /// <summary>
        /// The time this object was created at.
        /// </summary>
        [JsonProperty("created_time")]
        public DateTime CreatedAt { get; }

        /// <summary>
        /// The time this object was last edited at.
        /// </summary>
        [JsonProperty("last_edited_time")]
        public DateTime LastEditedAt { get; }

        /// <summary>
        /// The user that created this instance.
        /// </summary>
        [JsonProperty("created_by")]
        public PartialNotionUser CreatedBy { get; }

        /// <summary>
        /// The last user that edited this instance.
        /// </summary>
        [JsonProperty("last_edited_by")]
        public PartialNotionUser LastEditedBy { get; }

        /// <summary>
        /// Gets the properties the database content uses.
        /// </summary>
        [JsonProperty("properties")]
        public TProperties Properties { get; }

        [JsonProperty("cover")]
        public FileProperty? Cover { get; }
    }
}
