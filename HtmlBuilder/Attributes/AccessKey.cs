using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Keyboard shortcut to activate or focus element
    /// </summary>
    public sealed class AccessKey : AttributeBase<string>
    {
        private const string name = "accesskey";

        public override string AttributeName => name;
    }
}
