using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// URLs to ping
    /// </summary>
    public sealed class Ping : AttributeBase<string>
    {
        private const string name = "ping";

        public override string AttributeName => name;
    }
}
