using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izolabella.Notion.Objects.Databases.Properties.Implementations
{
    public class TitleText
    {
        public TitleText(TextProperty TextProperty)
        {
            this.TextProperty = TextProperty;
        }

        public TextProperty TextProperty { get; }
    }
}
