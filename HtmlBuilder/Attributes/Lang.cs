using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Language of the element
    /// </summary>
    public sealed class Lang : AttributeBase<string>
    {
        private const string name = "lang";

        public override string AttributeName => name;
    }
}
