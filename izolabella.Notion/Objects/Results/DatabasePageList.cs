﻿using izolabella.Notion.Objects.Databases;
using izolabella.Notion.Objects.Enums;

namespace izolabella.Notion.Objects.Results
{
    public class DatabasePageList<TProperties> : NotionObject
    {
        [JsonConstructor]
        internal DatabasePageList(PageObject<TProperties>[] Result, bool HasMore, string Id, NotionObjectType O) : base(Id, O)
        {
            this.Result = Result;
            this.HasMore = HasMore;
        }

        [JsonProperty("results")]
        public PageObject<TProperties>[] Result { get; }

        [JsonProperty("has_more")]
        public bool HasMore { get; }
    }
}
