using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether the element is to have its spelling and grammar checked
    /// </summary>
    public sealed class SpellCheck : AttributeBase<bool>
    {
        private const string name = "spellcheck";

        public override string AttributeName => name;
    }
}
