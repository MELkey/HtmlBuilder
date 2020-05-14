using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Classes to which the element belongs
    /// </summary>
    public sealed class Class : AttributeBase<string[]>
    {
        private const string name = "class";

        public override string AttributeName => name;

        public void SetValue(string value)
        {
            base.SetValue(new[] { value });
        }
    }
}
