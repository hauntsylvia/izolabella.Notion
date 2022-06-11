using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.Notion.Objects.Databases.Content
{
    public class DateContent
    {
        public DateContent(DateTime Start, DateTime? End)
        {
            this.Start = Start;
            this.End = End;
        }

        [JsonProperty("start")]
        public DateTime Start { get; }

        [JsonProperty("end")]
        public DateTime? End { get; }
    }
}
