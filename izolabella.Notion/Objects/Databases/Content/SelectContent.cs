using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.Notion.Objects.Databases.Content
{
    public class SelectContent
    {
        public SelectContent(string Id, string Name, string ColorName)
        {
            this.Id = Id;
            this.SelectedName = Name;
            this.ColorName = ColorName;
        }

        [JsonProperty("id")]
        public string Id { get; }

        [JsonProperty("name")]
        public string SelectedName { get; }

        [JsonProperty("color")]
        public string ColorName { get; }
    }
}
