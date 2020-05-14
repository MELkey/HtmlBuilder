using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    public class CustomAttribute : AttributeBase<string>
    {
        protected readonly string name;

        public CustomAttribute(string name)
        {
            this.name = name;
        }

        public override string AttributeName => name;
    }
}
