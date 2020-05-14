using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Item types of a microdata item
    /// </summary>
    public sealed class ItemType : AttributeBase<string>
    {
        private const string name = "itemtype";

        public override string AttributeName => name;
    }
}
