using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the element is focusable and sequentially focusable, 
    /// and the relative order of the element for the purposes of 
    /// sequential focus navigation
    /// </summary>
    public sealed class TabIndex : AttributeBase<int>
    {
        private const string name = "tabindex";

        public override string AttributeName => name;
    }
}
