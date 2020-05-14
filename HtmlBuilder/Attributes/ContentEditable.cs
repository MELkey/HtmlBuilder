using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the element is editable
    /// </summary>
    public sealed class ContentEditable : AttributeBase<bool>
    {
        private const string name = "contenteditable";

        public override string AttributeName => name;
    }
}
