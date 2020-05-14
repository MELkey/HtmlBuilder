using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the element is to be translated when the page is localized
    /// </summary>
    public sealed class Translate : AttributeBase<TranslateValue>
    {
        private const string name = "translate";

        public override string AttributeName => name;
    }
}
