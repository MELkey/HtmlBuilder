using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the element is draggable
    /// </summary>
    public sealed class Draggable : AttributeBase<bool>
    {
        private const string name = "draggable";

        public override string AttributeName => name;
    }
}
