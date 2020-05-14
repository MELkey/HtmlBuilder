using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Global identifier for a microdata item
    /// </summary>
    public sealed class ItemId : AttributeBase<string>
    {
        private const string name = "itemid";

        public override string AttributeName => name;
    }
}
