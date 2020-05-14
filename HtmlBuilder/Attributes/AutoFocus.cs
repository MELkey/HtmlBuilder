using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Automatically focus the element when the page is loaded
    /// </summary>
    public sealed class AutoFocus : AttributeBase<bool>
    {
        private const string name = "autofocus";

        public override string AttributeName => name;
    }
}
