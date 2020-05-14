using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Number of columns spanned by the element
    /// </summary>
    public sealed class Span : AttributeBase<uint>
    {
        private const string name = "span";

        public override string AttributeName => name;
    }
}
