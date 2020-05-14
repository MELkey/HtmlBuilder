using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlBuilder.Attributes
{
    /// <summary>
    /// Type of button	
    /// </summary>
    public sealed class TypeButton : AttributeBase<TypeButtonValue>
    {
        private const string name = "type";

        public override string AttributeName => name;
    }
}
