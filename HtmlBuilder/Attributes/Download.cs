using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Whether to download the resource instead of navigating to it, and its file name if so
    /// </summary>
    public sealed class Download : AttributeBase<string>
    {
        private const string name = "download";

        public override string AttributeName => name;
    }
}
