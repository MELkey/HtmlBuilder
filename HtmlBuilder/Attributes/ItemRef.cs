using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Referenced elements
    /// </summary>
    public sealed class ItemRef : AttributeBase<string>
    {
        private const string name = "itemref";

        public override string AttributeName => name;
    }
}
