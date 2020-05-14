using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Hint for selecting an enter key action
    /// </summary>
    public sealed class EnterKeyHint : AttributeBase<EnterKeyHintValue>
    {
        private const string name = "enterkeyhint";

        public override string AttributeName => name;
    }
}
