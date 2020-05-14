using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Prevents execution in user agents that support module scripts
    /// </summary>
    public sealed class NoModule : AttributeBase<bool>
    {
        private const string name = "nomodule";

        public override string AttributeName => name;
    }
}
