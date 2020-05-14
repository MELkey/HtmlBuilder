using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Title
    /// </summary>
    public sealed class Title : AttributeBase<string>
    {
        private const string name = "title";

        public override string AttributeName => name;
    }
}
