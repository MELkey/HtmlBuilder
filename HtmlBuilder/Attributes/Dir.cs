using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// The text directionality of the element
    /// </summary>
    public sealed class Dir : AttributeBase<DirValue>
    {
        private const string name = "dir";

        public override string AttributeName => name;
    }
}
