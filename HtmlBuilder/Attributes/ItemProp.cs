using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Property names of a microdata item
    /// </summary>
    public sealed class ItemProp : AttributeBase<string>
    {
        private const string name = "itemprop";

        public override string AttributeName => name;
    }
}
