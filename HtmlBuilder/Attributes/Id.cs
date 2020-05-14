using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// The element's ID
    /// </summary>
    public sealed class Id : AttributeBase<string>
    {
        private const string name = "id";

        public override string AttributeName => name;
    }
}
