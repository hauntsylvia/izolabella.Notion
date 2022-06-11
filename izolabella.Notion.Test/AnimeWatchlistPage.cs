using izolabella.Notion.Objects.Databases;
using izolabella.Notion.Objects.Databases.Properties.Implementations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.Notion.Test
{
    public class AnimeWatchlistPage
    {
        [JsonConstructor]
        public AnimeWatchlistPage(RichText Notes)
        {
            this.Notes = Notes;
        }

        [JsonProperty("notes")]
        public RichText Notes { get; }
    }
}
