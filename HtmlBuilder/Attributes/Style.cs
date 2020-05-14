using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Presentational and formatting instructions
    /// </summary>
    public sealed class Style : AttributeBase<string>
    {
        private const string name = "style";

        public override string AttributeName => name;
    }
}
