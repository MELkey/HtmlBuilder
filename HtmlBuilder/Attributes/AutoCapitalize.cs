using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Recommended autocapitalization behavior (for supported input methods)
    /// </summary>
    public sealed class AutoCapitalize : AttributeBase<AutoCapitalizeValues>
    {
        private const string name = "autocapitalize";

        public override string AttributeName => name;
    }
}
