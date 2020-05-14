using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the element is relevant
    /// </summary>
    public sealed class Hidden : AttributeBase<bool>
    {
        private const string name = "hidden";

        public override string AttributeName => name;
    }
}
