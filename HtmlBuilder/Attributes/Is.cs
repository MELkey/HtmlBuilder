using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Creates a customized built-in element
    /// </summary>
    public sealed class Is : AttributeBase<string>
    {
        private const string name = "is";

        public override string AttributeName => name;
    }
}
