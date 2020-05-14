using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// The element's desired slot
    /// </summary>
    public sealed class Slot : AttributeBase<string>
    {
        private const string name = "slot";

        public override string AttributeName => name;
    }
}
