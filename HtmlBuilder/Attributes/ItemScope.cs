using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Introduces a microdata item
    /// </summary>
    public sealed class ItemScope : AttributeBase<bool>
    {
        private const string name = "itemscope";

        public override string AttributeName => name;
    }
}
