using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Cryptographic nonce used in Content Security Policy checks [CSP]
    /// </summary>
    public sealed class Nonce : AttributeBase<string>
    {
        private const string name = "nonce";

        public override string AttributeName => name;
    }
}
