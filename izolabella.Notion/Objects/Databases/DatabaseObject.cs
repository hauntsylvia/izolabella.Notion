using izolabella.Notion.Objects.Databases.Properties.Bases;
using izolabella.Notion.Objects.Results;
using izolabella.Notion.Objects.Users;
using izolabella.Notion.Objects.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.Notion.Objects.Databases
{
    /// <summary>
    /// A class representing a database object.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DatabaseObject<TProperties> : NotionObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseObject"/> class.
        /// </summary>
        /// <param name="Id">The unique identifier of this instance.</param>
        /// <param name="CreatedAt">The time this object was created.</param>
        /// <param name="LastEditedAt">The</param>
        /// <param name="Title"></param>
        /// <param name="CreatedBy"></param>
        /// <param name="LastEditedBy"></param>
        /// <param name="Url"></param>
        /// <param name="Archived"></param>
        /// <param name="Properties"></param>
        [JsonConstructor]
        internal DatabaseObject(string Id,
                                DateTime CreatedAt,
                                DateTime LastEditedAt,
                                DatabaseObjectProperty[] Title,
                                PartialNotionUser CreatedBy,
                                PartialNotionUser LastEditedBy,
                                Uri Url,
                                bool Archived,
                                TProperties Properties) : base(Id, Enums.NotionObjectType.Database)
        {
            this.CreatedAt = CreatedAt;
            this.LastEditedAt = LastEditedAt;
            this.Title = Title;
            this.CreatedBy = CreatedBy;
            this.LastEditedBy = LastEditedBy;
            this.Url = Url;
            this.Archived = Archived;
            this.Properties = Properties;
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
        /// The title of this object.
        /// </summary>
        [JsonProperty("title")]
        public DatabaseObjectProperty[] Title { get; }

        /// <summary>
        /// The url to this database.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; }

        /// <summary>
        /// Whether or not this database has been archived.
        /// </summary>
        [JsonProperty("archived")]
        public bool Archived { get; }

        /// <summary>
        /// Gets the properties the database content uses.
        /// </summary>
        [JsonProperty("properties")]
        public TProperties Properties { get; }

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
        /// Gets the pages this database has.
        /// </summary>
        /// <param name="NumberOfPages">The number of pages to return.</param>
        /// <returns></returns>
        public async Task<DatabasePageList<TProperties>> GetPages<TProperties>(int NumberOfPages = 100)
        {
            return (await NotionClient.GetResourceAsync<DatabasePageList<TProperties>>(this.MadeWith, await NotionClient.MakeRequestAsync(MadeWith, HttpMethod.Post, Urls.GetQueryDatabaseUrl(this.Id), 
                new Dictionary<string, int>()
                {
                    {"page_size", NumberOfPages }
                }))) ?? new DatabasePageList<TProperties>(Array.Empty<PageObject<TProperties>>(), false, "", Enums.NotionObjectType.List);
        }
    }
}
